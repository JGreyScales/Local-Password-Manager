namespace Local_Password_Manager
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
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
            ErrorLabel.Location = point;
            ErrorLabel.Visible = true;
            ErrorLabel.Text = text;
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
            InputParent.Text = "";
            InputUsername.Text = "";
            InputPassword.Text = "";
            InputComment.Text = "";

            InputParent.PlaceholderText = "Input a Parent Title";
            InputUsername.PlaceholderText = "Input Username";
            InputPassword.PlaceholderText = "Input Password";
            InputComment.PlaceholderText = "Input Comments*";

            creationDateLabel.Visible = false;
            lastUsedLabel.Visible = false;
            commentLabel.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            ErrorLabel.Visible = false;

            if (x == 1)
            {
                BackButton.Visible = true;
                AddInfoButton.Visible = false;
                RemoveInfoButton.Visible = false;
                AutoCompleteSuggestionBox.Visible = false;
                EditInfoButton.Visible = false;
                return;
            }
            AutoCompleteSuggestionBox.Items.Clear();


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
            try
            {
                // after user has selected Parent, display all children in respective spots
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
                        EditInfoButton.Visible = true;
                        creationDateLabel.Visible = true;
                        lastUsedLabel.Visible = true;
                        commentLabel.Visible = true;
                        usernameLabel.Visible = true;
                        passwordLabel.Visible = true;
                        Input1.Text = "";
                        AutoCompleteSuggestionBox.Visible = false;

                        creationDateLabel.Text = $@"Creation Date:  {names[selectedKey]["creation-date"]}";
                        lastUsedLabel.Text = $@"Last Used Date:  {names[selectedKey]["last-used-date"]}";
                        commentLabel.Text = $@"comments: {names[selectedKey]["comments"]}";
                        usernameLabel.Text = $@"Username:   {names[selectedKey]["username"]}";



                        // display only 10% of password, 90% is '*' 's
                        string pass = "";
                        for (int i = 0; i < names[selectedKey]["password"].ToString().Count(); i++)
                        {
                            if (i < names[selectedKey]["password"].ToString().Count() * .1)
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
                    else
                    {
                        EditInfoButton.Visible = false;
                    }
                }
            }
            catch
            {

            }


        }




        private void updateLabels(string KEY)
        {
            string newData = "";
            // internal clock to remove the 'item copied' text after two seconds
            InteralClock.Start();
            string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());

                Clipboard.SetText(names[selectedKey][KEY].ToString());

                int count = 0;
                foreach (string line in System.IO.File.ReadLines(@"1ab2ba2.json"))
                {
                    if (count > 0)
                    {
                        count--;
                        if (count == 1)
                        {
                            newData = newData + "        \"last-used-date\":\"" + DateTime.Now.Date.ToString() + "\",\r\n";
                            continue;
                        }
                    }
                    else if (line.Contains(selectedKey))
                    {
                        count = 5;
                    }
                    newData = newData + line + System.Environment.NewLine;
                }
            }

            File.WriteAllText(@"1ab2ba2.json", newData);
            moveCopiedLabel(114, 136, "Text Copied");
            lastUsedLabel.Text = "Last Used Date:  " + DateTime.Now.Date.ToString();

        }

        // paired with the internal clock, handles some of the logic
        private void InteralClock_Tick(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
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
                    ApplyInfoButton.Visible = false;
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
                moveCopiedLabel(121, 224, "No item selected");
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
                        lineKey = line[6..end];
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
                            if (line.Trim() == "{")
                            {
                                textData = line;
                            }
                            else
                            {
                                textData = textData + System.Environment.NewLine + line;
                            }
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



                foreach (string line in System.IO.File.ReadLines(@"1ab2ba2.json"))
                {
                    if (line.Trim() == "{")
                    {
                        newData = line;
                    }
                    else if (line.Trim() != "}")
                    {
                        newData = newData + System.Environment.NewLine + line;
                    }
                }
                foreach (string dataline in data)
                {
                    newData = newData + System.Environment.NewLine + dataline;
                }

                using (StreamReader r = new StreamReader("1ab2ba2.json"))
                {
                    JObject names = JObject.Parse(r.ReadToEnd());
                    foreach (KeyValuePair<string, JToken> title in names)
                    {
                        if (title.Key.ToString() == InputParent.Text)
                        {
                            moveCopiedLabel(114, 224, "Parent name in use");
                            return;
                        }
                    }
                }

                File.WriteAllText(@"1ab2ba2.json", newData);


                sceneChange(1);
            }
        }

        private void Edit_Button_clicked(object sender, EventArgs e)
        {
            // this works as an if statement since if no item is selected it throws a nullreference exepction which is caught in the catch
            string selectedKey = AutoCompleteSuggestionBox.SelectedItem.ToString();

            sceneChange(2);
            addItemButton.Visible = false;
            ApplyInfoButton.Visible = true;
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());

                InputParent.PlaceholderText = selectedKey;
                InputUsername.PlaceholderText = names[selectedKey]["username"].ToString();
                InputComment.PlaceholderText = names[selectedKey]["comments"].ToString();


                string pass = "";
                for (int i = 0; i < names[selectedKey]["password"].ToString().Count(); i++)
                {
                    if (i < names[selectedKey]["password"].ToString().Count() * .1)
                    {
                        pass = pass + names[selectedKey]["password"].ToString()[i];
                    }
                    else
                    {
                        pass = pass + "*";
                    }
                }

                InputPassword.PlaceholderText = pass;
            }

        }

        private void ApplyInfoButton_Click(object sender, EventArgs e)
        {
            string newData = "";
            using (StreamReader r = new StreamReader("1ab2ba2.json"))
            {
                JObject names = JObject.Parse(r.ReadToEnd());
                string key = AutoCompleteSuggestionBox.SelectedItem.ToString();


                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(InputParent);
                textBoxes.Add(InputUsername);
                textBoxes.Add(InputComment);

                string newline = System.Environment.NewLine;



                foreach (TextBox box in textBoxes)
                {
                    if (box.Text.Length < 1)
                    {
                        box.Text = box.PlaceholderText;
                    }
                }
                if (InputPassword.Text.Length < 1)
                {
                    InputPassword.Text = names[key]["password"].ToString();
                }

                int count = 0;
                foreach (string line in System.IO.File.ReadLines(@"1ab2ba2.json"))
                {
                    if (count > 0)
                    {
                        count--;
                    }
                    else if (line == "    ,\"" + AutoCompleteSuggestionBox.SelectedItem.ToString() + "\":{")
                    {
                        count = 5;

                        newData = newData + "    ,\"" + InputParent.Text + "\":{" + newline;
                        newData = newData + "        \"username\":\"" + InputUsername.Text + "\"," + newline;
                        newData = newData + "        \"password\":\"" + InputPassword.Text + "\"," + newline;
                        newData = newData + "        \"creation-date\":\"" + names[key]["creation-date"] + "\"," + newline + "        \"last-used-date\":\"" + names[key]["last-used-date"] + "\"," + newline;
                        newData = newData + "        \"comments\":\"" + InputComment.Text + "\"}" + newline;

                }
                    else
                    {
                        newData = newData + line + System.Environment.NewLine;
                    }
                }
            }
            File.WriteAllText(@"1ab2ba2.json", newData);
        }
    }
}