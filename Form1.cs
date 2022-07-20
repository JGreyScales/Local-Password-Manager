namespace Local_Password_Manager
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

        private void Input1_KeyUp(object sender, KeyEventArgs e)
        {
            ProgressBar.Value = 0;
            ProgressLabel.Text = "0/null";
            if (Input1.Text.Length > 0){
                AutoCompleteSuggestionBox.Visible = true;
                var predicted = namePrediction(Input1.Text);
                for (int i = 0; i < predicted.Count; i++)
                {
                    if (AutoCompleteSuggestionBox.Items.IndexOf(predicted[i]) == -1)
                    {
                        AutoCompleteSuggestionBox.Items.Add(predicted[i]);
                    }
                }

            }


            else{AutoCompleteSuggestionBox.Visible = false;}
        }

        private List<string> namePrediction(string key)
        {

            var results = new List<string>();
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());
                List<string> allNames = new List<string>();
                foreach(KeyValuePair<string, JToken> title in names)
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
                    label1.Text = i.ToString();
                    ProgressLabel.Text = ($@"{(50/(i+1)).ToString()}/{allNames.Count.ToString()}");
                    ProgressBar.Value = 50 / (i + 1);
                }


                foreach (KeyValuePair<string, int> scoredObject in valueScores)
                {

                }
               

            }


            return results;
        }

        private void AccountInfoDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

//string data -> list
//.count array total -> return total
//select top 4 


//return (from p in data
//where p.IndexOf(prefixText, StringComparison.OrdinalIgnoreCase) >= 0
//select p).Take<String>(count).ToArray();
//  }