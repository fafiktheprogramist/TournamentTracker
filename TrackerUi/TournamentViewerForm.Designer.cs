namespace TrackerUi
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropbox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusSign = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AccessibleName = "tournamentHeader";
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(338, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tournament";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Location = new System.Drawing.Point(368, 63);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(89, 36);
            this.tournamentName.TabIndex = 7;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(22, 99);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(83, 36);
            this.roundLabel.TabIndex = 8;
            this.roundLabel.Text = "Round";
            // 
            // roundDropbox
            // 
            this.roundDropbox.FormattingEnabled = true;
            this.roundDropbox.Location = new System.Drawing.Point(122, 96);
            this.roundDropbox.Name = "roundDropbox";
            this.roundDropbox.Size = new System.Drawing.Size(209, 44);
            this.roundDropbox.TabIndex = 9;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(122, 147);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(128, 27);
            this.unplayedOnlyCheckbox.TabIndex = 10;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 36;
            this.matchupListBox.Location = new System.Drawing.Point(39, 198);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(292, 326);
            this.matchupListBox.TabIndex = 11;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Location = new System.Drawing.Point(394, 198);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(201, 36);
            this.teamOneName.TabIndex = 12;
            this.teamOneName.Text = "<TeamOneName>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(394, 234);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(79, 36);
            this.TeamOneScoreLabel.TabIndex = 13;
            this.TeamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreText
            // 
            this.teamOneScoreText.Location = new System.Drawing.Point(479, 231);
            this.teamOneScoreText.Name = "teamOneScoreText";
            this.teamOneScoreText.Size = new System.Drawing.Size(122, 45);
            this.teamOneScoreText.TabIndex = 14;
            // 
            // teamTwoScoreText
            // 
            this.teamTwoScoreText.Location = new System.Drawing.Point(479, 406);
            this.teamTwoScoreText.Name = "teamTwoScoreText";
            this.teamTwoScoreText.Size = new System.Drawing.Size(122, 45);
            this.teamTwoScoreText.TabIndex = 17;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(394, 406);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(79, 36);
            this.TeamTwoScoreLabel.TabIndex = 16;
            this.TeamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Location = new System.Drawing.Point(394, 370);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(204, 36);
            this.teamTwoName.TabIndex = 15;
            this.teamTwoName.Text = "<TeamTwoName>";
            // 
            // versusSign
            // 
            this.versusSign.AutoSize = true;
            this.versusSign.Location = new System.Drawing.Point(473, 307);
            this.versusSign.Name = "versusSign";
            this.versusSign.Size = new System.Drawing.Size(43, 36);
            this.versusSign.TabIndex = 18;
            this.versusSign.Text = "VS";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(650, 292);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(137, 66);
            this.scoreButton.TabIndex = 19;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1733, 1061);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusSign);
            this.Controls.Add(this.teamTwoScoreText);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreText);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropbox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropbox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreText;
        private System.Windows.Forms.TextBox teamTwoScoreText;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusSign;
        private System.Windows.Forms.Button scoreButton;
    }
}

