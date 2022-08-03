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

        private void moveCopiedLabel(int x, int y, string text)
        {
            System.Drawing.Point point = new System.Drawing.Point(x, y);
            textCopiedLabel.Location = point;
            textCopiedLabel.Visible = true;
            textCopiedLabel.Text = text;
            if (InteralClock.Enabled == true)
            {
                InteralClock.Stop();
            }
            InteralClock.Start();
        }

        private void clearAuto(int x)
        {


            // for proccessing 'different' scenes when gathering data
            ProgressBar.Value = 0;
            ProgressLabel.Text = "0/null";
            AutoCompleteSuggestionBox.Items.Clear();
            creationDateLabel.Visible = false;
            lastUsedLabel.Visible = false;
            commentLabel.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            textCopiedLabel.Visible = false;

            if (x == 1)
            {
                BackButton.Visible = true;
                AddInfoButton.Visible = false;
                RemoveInfoButton.Visible = false;
                AutoCompleteSuggestionBox.Visible = false;
            }

        }

        private void Input1_KeyUp(object sender, KeyEventArgs e)
        {



            clearAuto(0);


            // Gather predicted items for display in the item box
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


            // Gather results from JSON file and parse through them to find possible matches with current input text

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




                // Order gathered data by its score (how likely it is to be a match)

                var list = valueScores.Values.OrderByDescending(x => x).ToList();
                var sortedData = valueScores.OrderBy(x => list.IndexOf(x.Value));
                foreach (KeyValuePair<string, int> value in sortedData)
                {

                    // return ordered pair
                    results.Add(value.Key.ToString());

                }
            }


            return results;
        }

        public void AutoCompleteSuggestionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // after user has selected Parent, display all children in respective spots
            try
            {
                string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();


                using (StreamReader r = new StreamReader("1ab2ba2.json"))
                {
                    JObject names = JObject.Parse(r.ReadToEnd());
                    List<string> allNames = new List<string>();
                    foreach (KeyValuePair<string, JToken> title in names)
                    {
                        allNames.Add(title.Key.ToString());
                    }

                    if (AddInfoButton.Visible)
                    {
                        creationDateLabel.Visible = true;
                        lastUsedLabel.Visible = true;
                        commentLabel.Visible = true;
                        usernameLabel.Visible = true;
                        passwordLabel.Visible = true;
                        Input1.Text = "";
                        AutoCompleteSuggestionBox.Visible = false;

                        creationDateLabel.Text = $@"Creation Date:  {names[selectedKey]["creation-date"].ToString()}";
                        lastUsedLabel.Text = $@"Last Used Date:  {names[selectedKey]["last-used-date"].ToString()}";
                        commentLabel.Text = $@"comments:    {names[selectedKey]["comments"].ToString()}";
                        usernameLabel.Text = $@"Username:   {names[selectedKey]["username"].ToString()}";



                        // display only 10% of password, 90% is '*' 's
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
                    else if (DelParentButton.Visible)
                    {
                        Input1.Text = selectedKey;
                        AutoCompleteSuggestionBox.Visible = false;
                    }
                }
            }
            // unsure how to proceed, this is to catch if any user data is missing or corrupted
            catch
            {

            }

            // I DID IT FOR U FUTURE ME, FUCK U. TAKE THIS VALUE [SELECTED KEY] AND PARSE THROUGH KNOWN PARENTS AND REMOVE ANY DIRECT MATCHES

        }




        private void updateLabels(string KEY)
        {

            // internal clock to remove the 'item copied' text after two seconds
            InteralClock.Start();
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
                moveCopiedLabel(256, 242, "Text Copied");
            }

        }

        // paired with the internal clock, handles some of the logic
        private void InteralClock_Tick(object sender, EventArgs e)
        {
            textCopiedLabel.Visible = false;
            InteralClock.Stop();

        }

        // Copies text to clipboard, unsure how to improve this system. Password will need extra stesp to copy to clipboard as encryption will be applied
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

        // handles scene management. Unsure how to proceed, this system works but is bulky and can most likely be trimmed
        private void sceneChange(int sceneInt)
        {
            switch (sceneInt)
            {
                case 1:
                    clearAuto(0);

                    Input1.Visible = true;
                    AddInfoButton.Visible = true;
                    RemoveInfoButton.Visible = true;

                    BackButton.Visible = false;
                    DelParentButton.Visible = false;

                    InputParent.Visible = false;
                    InputUsername.Visible = false;
                    InputPassword.Visible = false;
                    InputComment.Visible = false;
                    addItemButton.Visible = false;
                    break;

                case 2:
                    clearAuto(1);
                    InputParent.Visible = true;
                    InputUsername.Visible = true;
                    InputPassword.Visible = true;
                    InputComment.Visible = true;
                    addItemButton.Visible = true;
                    Input1.Visible = false;

                    break;

                case 3:

                    clearAuto(1);
                    DelParentButton.Visible = true;
                    break;

            }
        }



        // proccesses what button has been pressed and sends to a scene manager respectively
        private void backButtonClick(object sender, EventArgs e)
        {
            Input1.Text = "";
            sceneChange(1);
        }
        private void AddInfoButton_Click(object sender, EventArgs e)
        {
            sceneChange(2);
        }



        // handels all removal scene info
        private void RemoveInfoButton_Click(object sender, EventArgs e)
        {
            sceneChange(3);
        }



        // will delete currently selected parent from the directory
        private void DelParentButton_Click(object sender, EventArgs e)
        {
            string key = Input1.Text;
            if (key.Length < 1)
            {
                moveCopiedLabel(121, 224, "No Item Selected");
            }
            else
            {
                bool title = false;
                string textData = "", lineKey = "";
                int end = 0, ignore = 0;
                foreach (string line in System.IO.File.ReadLines(@"1ab2ba2.json"))
                {
                    try
                    {
                        end = line.IndexOf('{', 7) - 2;
                        lineKey = line.Substring(6, end - 6);
                        title = true;
                    }
                    catch
                    {
                        title = false;
                    }
                    finally
                    {
                        if (ignore > 0)
                        {
                            ignore--;
                        }
                        else if (lineKey == key && title)
                        {
                            ignore = 5;
                        }
                        else
                        {
                            textData = textData + System.Environment.NewLine + line;
                        }
                    }
                }

                File.WriteAllText(@"1ab2ba2.json", textData);
                moveCopiedLabel(139, 224, "Deleted Item");
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            bool passed = true;
            List<string> texts = new List<string>();
            string newData = "";
            texts.Add(InputParent.Text);
            texts.Add(InputUsername.Text);
            texts.Add(InputPassword.Text);
            foreach (string text in texts)
            {
                if (text.Length < 1)
                {
                    moveCopiedLabel(76, 224, "Ensure all required info is filled");
                    passed = false;
                }                
            }

            if (passed)
            {

                List<string> data = new List<string>();
                string comments = " ";
                data.Add("    ,\"" + InputParent.Text + "\":{");
                data.Add("        \"username\":\"" + InputUsername.Text + "\",");
                data.Add("        \"password\":\"" + InputPassword.Text + "\",");
                data.Add("        \"creation-date\":\"" + DateTime.Now.Date.ToString() + "\",");
                data.Add("        \"last-used-date\":\"" + DateTime.Now.Date.ToString() + "\",");
                if (InputComment.Text.Length > 0)
                {
                    comments = InputComment.Text;
                }
                data.Add("        \"comments\":\"" + comments + "\"}");
                data.Add("}");


                label1.Text = newData;
                foreach (string line in System.IO.File.ReadLines(@"1ab2ba2.json"))
                {
                    if (line.Trim() != "}")
                    {
                        newData = newData + System.Environment.NewLine + line;
                    }
                }

                foreach (string dataline in data)
                {
                    newData = newData + System.Environment.NewLine + dataline;
                }
                File.WriteAllText(@"1ab2ba2.json", newData);
            }
        }
    }
}