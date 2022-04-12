namespace CardGame2022
{
    partial class MainWindow
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
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.rowOneLabel = new System.Windows.Forms.Label();
            this.rowTwoLabel = new System.Windows.Forms.Label();
            this.rowThreeLabel = new System.Windows.Forms.Label();
            this.rowFourLabel = new System.Windows.Forms.Label();
            this.playerOneHandLabel = new System.Windows.Forms.Label();
            this.playerTwoHandLabel = new System.Windows.Forms.Label();
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.labelRowTable = new System.Windows.Forms.Label();
            this.labelCards1 = new System.Windows.Forms.Label();
            this.labelCards2 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageListBox
            // 
            this.messageListBox.CausesValidation = false;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 16;
            this.messageListBox.Location = new System.Drawing.Point(743, 30);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(544, 516);
            this.messageListBox.TabIndex = 1;
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(743, 561);
            this.entryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(544, 22);
            this.entryTextBox.TabIndex = 0;
            this.entryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryTextBox_KeyDown);
            // 
            // playerOneHandLabel
            // 
            this.playerOneHandLabel.AutoSize = true;
            this.playerOneHandLabel.BackColor = System.Drawing.Color.Lime;
            this.playerOneHandLabel.ForeColor = System.Drawing.Color.DimGray;
            this.playerOneHandLabel.Location = new System.Drawing.Point(19, 319);
            this.playerOneHandLabel.Name = "playerOneHandLabel";
            this.playerOneHandLabel.Size = new System.Drawing.Size(22, 16);
            this.playerOneHandLabel.TabIndex = 6;
            this.playerOneHandLabel.Text = "     ";
            this.playerOneHandLabel.Visible = false;
            // 
            // playerTwoHandLabel
            // 
            this.playerTwoHandLabel.AutoSize = true;
            this.playerTwoHandLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.playerTwoHandLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.playerTwoHandLabel.Location = new System.Drawing.Point(19, 396);
            this.playerTwoHandLabel.Name = "playerTwoHandLabel";
            this.playerTwoHandLabel.Size = new System.Drawing.Size(22, 16);
            this.playerTwoHandLabel.TabIndex = 7;
            this.playerTwoHandLabel.Text = "     ";
            this.playerTwoHandLabel.Visible = false;
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.BackColor = System.Drawing.Color.Turquoise;
            this.playerOneScoreLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.playerOneScoreLabel.Location = new System.Drawing.Point(19, 565);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(25, 16);
            this.playerOneScoreLabel.TabIndex = 8;
            this.playerOneScoreLabel.Text = "      ";
            this.playerOneScoreLabel.Visible = false;
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.playerTwoScoreLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(361, 565);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(25, 16);
            this.playerTwoScoreLabel.TabIndex = 9;
            this.playerTwoScoreLabel.Text = "      ";
            this.playerTwoScoreLabel.Visible = false;
            // 
            // labelRowTable
            // 
            this.labelRowTable.AutoSize = true;
            this.labelRowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRowTable.Location = new System.Drawing.Point(16, 11);
            this.labelRowTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRowTable.Name = "labelRowTable";
            this.labelRowTable.Size = new System.Drawing.Size(125, 17);
            this.labelRowTable.TabIndex = 10;
            this.labelRowTable.Text = "row on the table";
            // 
            // labelCards1
            // 
            this.labelCards1.AutoSize = true;
            this.labelCards1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCards1.Location = new System.Drawing.Point(19, 289);
            this.labelCards1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCards1.Name = "labelCards1";
            this.labelCards1.Size = new System.Drawing.Size(112, 17);
            this.labelCards1.TabIndex = 11;
            this.labelCards1.Text = "cards player 1";
            // 
            // labelCards2
            // 
            this.labelCards2.AutoSize = true;
            this.labelCards2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCards2.Location = new System.Drawing.Point(19, 369);
            this.labelCards2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCards2.Name = "labelCards2";
            this.labelCards2.Size = new System.Drawing.Size(112, 17);
            this.labelCards2.TabIndex = 12;
            this.labelCards2.Text = "cards player 2";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore1.Location = new System.Drawing.Point(16, 530);
            this.labelScore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(112, 17);
            this.labelScore1.TabIndex = 13;
            this.labelScore1.Text = "score player 1";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore2.Location = new System.Drawing.Point(361, 530);
            this.labelScore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(112, 17);
            this.labelScore2.TabIndex = 14;
            this.labelScore2.Text = "score player 2";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(576, 502);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(100, 28);
            this.buttonRestart.TabIndex = 15;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(576, 553);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(100, 28);
            this.QuitButton.TabIndex = 16;
            this.QuitButton.Text = "Quitter";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 636);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.labelCards2);
            this.Controls.Add(this.labelCards1);
            this.Controls.Add(this.labelRowTable);
            this.Controls.Add(this.playerTwoScoreLabel);
            this.Controls.Add(this.playerOneScoreLabel);
            this.Controls.Add(this.playerTwoHandLabel);
            this.Controls.Add(this.playerOneHandLabel);
            this.Controls.Add(this.rowFourLabel);
            this.Controls.Add(this.rowThreeLabel);
            this.Controls.Add(this.rowTwoLabel);
            this.Controls.Add(this.rowOneLabel);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.messageListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "6 nimmt! (IUT version)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Label rowOneLabel;
        private System.Windows.Forms.Label rowTwoLabel;
        private System.Windows.Forms.Label rowThreeLabel;
        private System.Windows.Forms.Label rowFourLabel;
        private System.Windows.Forms.Label playerOneHandLabel;
        private System.Windows.Forms.Label playerTwoHandLabel;
        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.Label playerTwoScoreLabel;
        private System.Windows.Forms.Label labelRowTable;
        private System.Windows.Forms.Label labelCards1;
        private System.Windows.Forms.Label labelCards2;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button QuitButton;
    }
}

