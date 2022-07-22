namespace Local_Password_Manager
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
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
            creationDateLabel.Visible = false;
            lastUsedLabel.Visible = false;
            commentLabel.Visible = false;
            usernameLabel.Visible = false;  
            passwordLabel.Visible = false;
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

        public void AutoCompleteSuggestionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();
                creationDateLabel.Visible = true;
                lastUsedLabel.Visible = true;
                commentLabel.Visible = true;
                usernameLabel.Visible = true;
                passwordLabel.Visible = true;
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



                    creationDateLabel.Text = $@"Creation Date:  {names[selectedKey]["creation-date"].ToString()}";
                    lastUsedLabel.Text = $@"Last Used Date:  {names[selectedKey]["last-used-date"].ToString()}";
                    commentLabel.Text = $@"comments:    {names[selectedKey]["comments"].ToString()}";

                    usernameLabel.Text = $@"Username:   {names[selectedKey]["username"].ToString()}";

                    string pass = "";
                    for (int i = 0; i < names[selectedKey]["password"].ToString().Count(); i++)
                    {
                        if (i < names[selectedKey]["password"].ToString().Count() / 10)
                        {
                            pass = pass + names[selectedKey]["password"].ToString()[i];
                        }
                        else
                        {
                            pass = pass + "*";
                        }
                    }

                    passwordLabel.Text = $@"Password:   {pass}";

                }
            }
            catch
            {

            }
        }

        private void updateLabels(string KEY)
        {
            InteralClock.Start();
            InternalClockValue.Text = "0";
            string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());
                List<string> allNames = new List<string>();
                foreach (KeyValuePair<string, JToken> title in names)
                {
                    allNames.Add(title.Key.ToString());
                }
                Clipboard.SetText(names[selectedKey][KEY].ToString());
                textCopiedLabel.Visible = true;
            }
            
        }

        private void creationDateLabel_Click(object sender, EventArgs e)
        {
            updateLabels("creation-date");
        }

        private void lastUsedLabel_Click(object sender, EventArgs e)
        {
            updateLabels("last-used-date");
        }

        private void commentLabel_Click(object sender, EventArgs e)
        {
            updateLabels("comments");
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            updateLabels("username");
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            // call decypt function, seperate send case will be needed
            updateLabels("password");
        }

        private void InteralClock_Tick(object sender, EventArgs e)
        {
            InternalClockValue.Text = (Int32.Parse(InternalClockValue.Text) + 1).ToString();
            if (Int32.Parse(InternalClockValue.Text) > 39)
            {
                textCopiedLabel.Visible = false;
                InteralClock.Stop();
                InternalClockValue.Text = "0";
            }
        }
    }
}