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
            this.InternalClockValue = new System.Windows.Forms.Label();
            this.textCopiedLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.ProgressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressLabel.Size = new System.Drawing.Size(38, 17);
            this.ProgressLabel.Text = "0/null";
            // 
            // Input1
            // 
            this.Input1.BackColor = System.Drawing.Color.LightGray;
            this.Input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Input1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Input1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Input1.Location = new System.Drawing.Point(12, 12);
            this.Input1.MaxLength = 45;
            this.Input1.Name = "Input1";
            this.Input1.PlaceholderText = "Input a title";
            this.Input1.Size = new System.Drawing.Size(328, 26);
            this.Input1.TabIndex = 4;
            this.Input1.Tag = "InputType";
            this.Input1.WordWrap = false;
            this.Input1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input1_KeyUp);
            // 
            // AutoCompleteSuggestionBox
            // 
            this.AutoCompleteSuggestionBox.BackColor = System.Drawing.Color.Gainsboro;
            this.AutoCompleteSuggestionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoCompleteSuggestionBox.CheckOnClick = true;
            this.AutoCompleteSuggestionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoCompleteSuggestionBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoCompleteSuggestionBox.Location = new System.Drawing.Point(12, 44);
            this.AutoCompleteSuggestionBox.Name = "AutoCompleteSuggestionBox";
            this.AutoCompleteSuggestionBox.Size = new System.Drawing.Size(328, 137);
            this.AutoCompleteSuggestionBox.TabIndex = 2;
            this.AutoCompleteSuggestionBox.Tag = "InputType";
            this.AutoCompleteSuggestionBox.Visible = false;
            this.AutoCompleteSuggestionBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AutoCompleteSuggestionBox_ItemCheck);
            this.AutoCompleteSuggestionBox.SelectedIndexChanged += new System.EventHandler(this.AutoCompleteSuggestionBox_SelectedIndexChanged);
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.creationDateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creationDateLabel.Location = new System.Drawing.Point(12, 184);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(82, 15);
            this.creationDateLabel.TabIndex = 6;
            this.creationDateLabel.Text = "Creation Date:";
            this.creationDateLabel.Visible = false;
            this.creationDateLabel.Click += new System.EventHandler(this.creationDateLabel_Click);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.commentLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentLabel.Location = new System.Drawing.Point(12, 214);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(69, 15);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "Comments:";
            this.commentLabel.Visible = false;
            this.commentLabel.Click += new System.EventHandler(this.commentLabel_Click);
            // 
            // lastUsedLabel
            // 
            this.lastUsedLabel.AutoSize = true;
            this.lastUsedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.lastUsedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastUsedLabel.Location = new System.Drawing.Point(12, 199);
            this.lastUsedLabel.Name = "lastUsedLabel";
            this.lastUsedLabel.Size = new System.Drawing.Size(60, 15);
            this.lastUsedLabel.TabIndex = 8;
            this.lastUsedLabel.Text = "Last Used:";
            this.lastUsedLabel.Visible = false;
            this.lastUsedLabel.Click += new System.EventHandler(this.lastUsedLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameLabel.Location = new System.Drawing.Point(12, 238);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Visible = false;
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLabel.Location = new System.Drawing.Point(12, 253);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Visible = false;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // AddInfoButton
            // 
            this.AddInfoButton.BackColor = System.Drawing.Color.LightGray;
            this.AddInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInfoButton.Location = new System.Drawing.Point(256, 187);
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.Size = new System.Drawing.Size(84, 23);
            this.AddInfoButton.TabIndex = 11;
            this.AddInfoButton.Text = "Add Info";
            this.AddInfoButton.UseVisualStyleBackColor = false;
            // 
            // RemoveInfoButton
            // 
            this.RemoveInfoButton.Location = new System.Drawing.Point(256, 216);
            this.RemoveInfoButton.Name = "RemoveInfoButton";
            this.RemoveInfoButton.Size = new System.Drawing.Size(84, 23);
            this.RemoveInfoButton.TabIndex = 12;
            this.RemoveInfoButton.Text = "Remove Info";
            this.RemoveInfoButton.UseVisualStyleBackColor = true;
            // 
            // InteralClock
            // 
            this.InteralClock.Interval = 50;
            this.InteralClock.Tick += new System.EventHandler(this.InteralClock_Tick);
            // 
            // InternalClockValue
            // 
            this.InternalClockValue.AutoSize = true;
            this.InternalClockValue.Location = new System.Drawing.Point(339, 261);
            this.InternalClockValue.Name = "InternalClockValue";
            this.InternalClockValue.Size = new System.Drawing.Size(13, 15);
            this.InternalClockValue.TabIndex = 13;
            this.InternalClockValue.Text = "0";
            this.InternalClockValue.Visible = false;
            // 
            // textCopiedLabel
            // 
            this.textCopiedLabel.AutoSize = true;
            this.textCopiedLabel.BackColor = System.Drawing.Color.LightGray;
            this.textCopiedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCopiedLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCopiedLabel.Location = new System.Drawing.Point(256, 242);
            this.textCopiedLabel.Name = "textCopiedLabel";
            this.textCopiedLabel.Size = new System.Drawing.Size(90, 22);
            this.textCopiedLabel.TabIndex = 14;
            this.textCopiedLabel.Text = "Text Copied";
            this.textCopiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textCopiedLabel.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(352, 298);
            this.Controls.Add(this.textCopiedLabel);
            this.Controls.Add(this.InternalClockValue);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Password Manager";
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
        private Label InternalClockValue;
        private Label textCopiedLabel;
    }
}