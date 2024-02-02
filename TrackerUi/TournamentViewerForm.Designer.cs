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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropbox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(789, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tournament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tournament:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tournament:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tournament:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tournament:";
            // 
            // label6
            // 
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
            this.roundLabel.Location = new System.Drawing.Point(33, 104);
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
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1733, 1061);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropbox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropbox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
    }
}

