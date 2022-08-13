namespace Local_Password_Manager
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.AutoCompleteSuggestionBox = new System.Windows.Forms.CheckedListBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.lastUsedLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.AddInfoButton = new System.Windows.Forms.Button();
            this.RemoveInfoButton = new System.Windows.Forms.Button();
            this.InteralClock = new System.Windows.Forms.Timer(this.components);
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DelParentButton = new System.Windows.Forms.Button();
            this.InputParent = new System.Windows.Forms.TextBox();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputComment = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.EditInfoButton = new System.Windows.Forms.Button();
            this.ApplyInfoButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.ProgressLabel});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressBar.Name = "ProgressBar";
            // 
            // ProgressLabel
            // 
            resources.ApplyResources(this.ProgressLabel, "ProgressLabel");
            this.ProgressLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressLabel.Name = "ProgressLabel";
            // 
            // Input1
            // 
            resources.ApplyResources(this.Input1, "Input1");
            this.Input1.BackColor = System.Drawing.Color.LightGray;
            this.Input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Input1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Input1.Name = "Input1";
            this.Input1.Tag = "InputType";
            this.Input1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input1_KeyUp);
            // 
            // AutoCompleteSuggestionBox
            // 
            resources.ApplyResources(this.AutoCompleteSuggestionBox, "AutoCompleteSuggestionBox");
            this.AutoCompleteSuggestionBox.BackColor = System.Drawing.Color.Gainsboro;
            this.AutoCompleteSuggestionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoCompleteSuggestionBox.CheckOnClick = true;
            this.AutoCompleteSuggestionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoCompleteSuggestionBox.Name = "AutoCompleteSuggestionBox";
            this.AutoCompleteSuggestionBox.Tag = "InputType";
            this.AutoCompleteSuggestionBox.SelectedIndexChanged += new System.EventHandler(this.AutoCompleteSuggestionBox_SelectedIndexChanged);
            // 
            // creationDateLabel
            // 
            resources.ApplyResources(this.creationDateLabel, "creationDateLabel");
            this.creationDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.creationDateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Click += new System.EventHandler(this.creationDateLabel_Click);
            // 
            // commentLabel
            // 
            resources.ApplyResources(this.commentLabel, "commentLabel");
            this.commentLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.commentLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Click += new System.EventHandler(this.commentLabel_Click);
            // 
            // lastUsedLabel
            // 
            resources.ApplyResources(this.lastUsedLabel, "lastUsedLabel");
            this.lastUsedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.lastUsedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastUsedLabel.Name = "lastUsedLabel";
            this.lastUsedLabel.Click += new System.EventHandler(this.lastUsedLabel_Click);
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // AddInfoButton
            // 
            resources.ApplyResources(this.AddInfoButton, "AddInfoButton");
            this.AddInfoButton.BackColor = System.Drawing.Color.LightGray;
            this.AddInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.UseVisualStyleBackColor = false;
            this.AddInfoButton.Click += new System.EventHandler(this.AddInfoButton_Click);
            // 
            // RemoveInfoButton
            // 
            resources.ApplyResources(this.RemoveInfoButton, "RemoveInfoButton");
            this.RemoveInfoButton.Name = "RemoveInfoButton";
            this.RemoveInfoButton.UseVisualStyleBackColor = true;
            this.RemoveInfoButton.Click += new System.EventHandler(this.RemoveInfoButton_Click);
            // 
            // InteralClock
            // 
            this.InteralClock.Interval = 2000;
            this.InteralClock.Tick += new System.EventHandler(this.InteralClock_Tick);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.BackColor = System.Drawing.Color.LightGray;
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // BackButton
            // 
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.BackColor = System.Drawing.Color.LightGray;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Name = "BackButton";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // DelParentButton
            // 
            resources.ApplyResources(this.DelParentButton, "DelParentButton");
            this.DelParentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelParentButton.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.DelParentButton.Name = "DelParentButton";
            this.DelParentButton.UseVisualStyleBackColor = true;
            this.DelParentButton.Click += new System.EventHandler(this.DelParentButton_Click);
            // 
            // InputParent
            // 
            resources.ApplyResources(this.InputParent, "InputParent");
            this.InputParent.BackColor = System.Drawing.Color.LightGray;
            this.InputParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputParent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputParent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputParent.Name = "InputParent";
            this.InputParent.Tag = "InputType";
            // 
            // InputUsername
            // 
            resources.ApplyResources(this.InputUsername, "InputUsername");
            this.InputUsername.BackColor = System.Drawing.Color.LightGray;
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Tag = "InputType";
            // 
            // InputPassword
            // 
            resources.ApplyResources(this.InputPassword, "InputPassword");
            this.InputPassword.BackColor = System.Drawing.Color.LightGray;
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Tag = "InputType";
            // 
            // InputComment
            // 
            resources.ApplyResources(this.InputComment, "InputComment");
            this.InputComment.BackColor = System.Drawing.Color.LightGray;
            this.InputComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputComment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InputComment.Name = "InputComment";
            this.InputComment.Tag = "InputType";
            // 
            // addItemButton
            // 
            resources.ApplyResources(this.addItemButton, "addItemButton");
            this.addItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemButton.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // EditInfoButton
            // 
            resources.ApplyResources(this.EditInfoButton, "EditInfoButton");
            this.EditInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditInfoButton.Name = "EditInfoButton";
            this.EditInfoButton.UseVisualStyleBackColor = true;
            this.EditInfoButton.Click += new System.EventHandler(this.Edit_Button_clicked);
            // 
            // ApplyInfoButton
            // 
            resources.ApplyResources(this.ApplyInfoButton, "ApplyInfoButton");
            this.ApplyInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyInfoButton.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.ApplyInfoButton.Name = "ApplyInfoButton";
            this.ApplyInfoButton.UseVisualStyleBackColor = true;
            this.ApplyInfoButton.Click += new System.EventHandler(this.ApplyInfoButton_Click);
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ApplyInfoButton);
            this.Controls.Add(this.EditInfoButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.InputComment);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.InputParent);
            this.Controls.Add(this.DelParentButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RemoveInfoButton);
            this.Controls.Add(this.AddInfoButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastUsedLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.AutoCompleteSuggestionBox);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Index";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgressBar;
        private ToolStripStatusLabel ProgressLabel;
        private TextBox Input1;
        private CheckedListBox AutoCompleteSuggestionBox;
        private Label creationDateLabel;
        private Label commentLabel;
        private Label lastUsedLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button AddInfoButton;
        private Button RemoveInfoButton;
        public System.Windows.Forms.Timer InteralClock;
        private Label ErrorLabel;
        private Button BackButton;
        private Button DelParentButton;
        private TextBox InputParent;
        private TextBox InputUsername;
        private TextBox InputPassword;
        private TextBox InputComment;
        private Button addItemButton;
        private Button EditInfoButton;
        private Button ApplyInfoButton;
    }
}