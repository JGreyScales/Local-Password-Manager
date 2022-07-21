namespace Local_Password_Manager
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.

{
    using Newtonsoft.Json.Linq;

    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        public void AutoCompleteSuggestionBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void clearAuto()
        {
            ProgressBar.Value = 0;
            ProgressLabel.Text = "0/null";
            AutoCompleteSuggestionBox.Items.Clear();
        }

        private void Input1_KeyUp(object sender, KeyEventArgs e)
        {
            clearAuto();
            if (Input1.Text.Length > 0)
            {
                AutoCompleteSuggestionBox.Visible = true;
                var predicted = namePrediction(Input1.Text);


                for (int i = 0; i < predicted.Count; i++)
                {
                    AutoCompleteSuggestionBox.Items.Add(predicted[i]);
                }

            }


            else { AutoCompleteSuggestionBox.Visible = false; }
        }



        public List<string> namePrediction(string key)
        {

            var results = new List<string>();
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());
                List<string> allNames = new List<string>();
                foreach (KeyValuePair<string, JToken> title in names)
                {
                    allNames.Add(title.Key.ToString());
                }

                Dictionary<string, int> valueScores = new Dictionary<string, int>();
                for (int i = 0; i < allNames.Count; i++)
                {
                    int score = new int();
                    for (int j = 0; j < key.Count(); j++)
                    {
                        try
                        {
                            if (key[j] == allNames[i][j])
                            {
                                score++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            break;
                        }
                    }
                    if (score > 0)
                    {
                        valueScores.Add(allNames[i], score);
                    }
                    ProgressLabel.Text = ($@"{(i + 1).ToString()}/{allNames.Count.ToString()}");
                    ProgressBar.Value = ((i + 1) / allNames.Count()) * 100;
                }


                var list = valueScores.Values.OrderByDescending(x => x).ToList();
                var sortedData = valueScores.OrderBy(x => list.IndexOf(x.Value));
                foreach (KeyValuePair<string, int> value in sortedData)
                {
                    results.Add(value.Key.ToString());

                }
            }


            return results;
        }

        private void AccountInfoDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AutoCompleteSuggestionBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();
            clearAuto();
            Input1.Text = "";
            AutoCompleteSuggestionBox.Visible = false;

            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());
                List<string> allNames = new List<string>();
                foreach (KeyValuePair<string, JToken> title in names)
                {
                    allNames.Add(title.Key.ToString());
                }

                creationDateLabel.Text = names[selectedKey]["creation-date"].ToString();
                lastUsedLabel.Text = names[selectedKey]["last-used-date"].ToString();


            }
        }
    }
}