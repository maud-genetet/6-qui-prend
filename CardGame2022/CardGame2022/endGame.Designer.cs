namespace CardGame2022
{
    partial class endGame
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
            this.partieTermineeLabel = new System.Windows.Forms.Label();
            this.listBoxScorePlayers = new System.Windows.Forms.ListBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partieTermineeLabel
            // 
            this.partieTermineeLabel.AutoSize = true;
            this.partieTermineeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partieTermineeLabel.ForeColor = System.Drawing.Color.Coral;
            this.partieTermineeLabel.Location = new System.Drawing.Point(90, 58);
            this.partieTermineeLabel.Name = "partieTermineeLabel";
            this.partieTermineeLabel.Size = new System.Drawing.Size(131, 20);
            this.partieTermineeLabel.TabIndex = 0;
            this.partieTermineeLabel.Text = "Partie terminée";
            // 
            // listBoxScorePlayers
            // 
            this.listBoxScorePlayers.FormattingEnabled = true;
            this.listBoxScorePlayers.Location = new System.Drawing.Point(79, 115);
            this.listBoxScorePlayers.Name = "listBoxScorePlayers";
            this.listBoxScorePlayers.Size = new System.Drawing.Size(153, 186);
            this.listBoxScorePlayers.TabIndex = 1;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Firebrick;
            this.RestartButton.Location = new System.Drawing.Point(94, 351);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(108, 42);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // endGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.listBoxScorePlayers);
            this.Controls.Add(this.partieTermineeLabel);
            this.Name = "endGame";
            this.Text = "Final Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partieTermineeLabel;
        private System.Windows.Forms.ListBox listBoxScorePlayers;
        private System.Windows.Forms.Button RestartButton;
    }
}