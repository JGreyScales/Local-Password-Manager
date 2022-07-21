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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.AutoCompleteSuggestionBox = new System.Windows.Forms.CheckedListBox();
            this.AccountInfoDisplay = new System.Windows.Forms.CheckedListBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.lastUsedLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Has username";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(115, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Has Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.ProgressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
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
            this.Input1.Location = new System.Drawing.Point(13, 37);
            this.Input1.MaxLength = 45;
            this.Input1.Name = "Input1";
            this.Input1.PlaceholderText = "Input a title";
            this.Input1.Size = new System.Drawing.Size(327, 26);
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
            this.AutoCompleteSuggestionBox.Location = new System.Drawing.Point(13, 69);
            this.AutoCompleteSuggestionBox.Name = "AutoCompleteSuggestionBox";
            this.AutoCompleteSuggestionBox.Size = new System.Drawing.Size(327, 137);
            this.AutoCompleteSuggestionBox.TabIndex = 2;
            this.AutoCompleteSuggestionBox.Tag = "InputType";
            this.AutoCompleteSuggestionBox.Visible = false;
            this.AutoCompleteSuggestionBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AutoCompleteSuggestionBox_ItemCheck);
            this.AutoCompleteSuggestionBox.SelectedIndexChanged += new System.EventHandler(this.AutoCompleteSuggestionBox_SelectedIndexChanged);
            // 
            // AccountInfoDisplay
            // 
            this.AccountInfoDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.AccountInfoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountInfoDisplay.CheckOnClick = true;
            this.AccountInfoDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountInfoDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountInfoDisplay.Location = new System.Drawing.Point(13, 287);
            this.AccountInfoDisplay.Name = "AccountInfoDisplay";
            this.AccountInfoDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountInfoDisplay.Size = new System.Drawing.Size(327, 107);
            this.AccountInfoDisplay.TabIndex = 5;
            this.AccountInfoDisplay.Tag = "InputType";
            this.AccountInfoDisplay.SelectedIndexChanged += new System.EventHandler(this.AccountInfoDisplay_SelectedIndexChanged);
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.creationDateLabel.Location = new System.Drawing.Point(13, 209);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(82, 15);
            this.creationDateLabel.TabIndex = 6;
            this.creationDateLabel.Text = "Creation Date:";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.commentLabel.Location = new System.Drawing.Point(13, 269);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(69, 15);
            this.commentLabel.TabIndex = 7;
            this.commentLabel.Text = "Comments:";
            // 
            // lastUsedLabel
            // 
            this.lastUsedLabel.AutoSize = true;
            this.lastUsedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.lastUsedLabel.Location = new System.Drawing.Point(13, 239);
            this.lastUsedLabel.Name = "lastUsedLabel";
            this.lastUsedLabel.Size = new System.Drawing.Size(60, 15);
            this.lastUsedLabel.TabIndex = 8;
            this.lastUsedLabel.Text = "Last Used:";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 428);
            this.Controls.Add(this.lastUsedLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.AccountInfoDisplay);
            this.Controls.Add(this.AutoCompleteSuggestionBox);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Password Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgressBar;
        private ToolStripStatusLabel ProgressLabel;
        private TextBox Input1;
        private CheckedListBox AutoCompleteSuggestionBox;
        private CheckedListBox AccountInfoDisplay;
        private Label creationDateLabel;
        private Label commentLabel;
        private Label lastUsedLabel;
    }
}