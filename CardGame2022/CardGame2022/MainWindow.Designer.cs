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
            this.labelRowTable = new System.Windows.Forms.Label();
            this.labelCards1 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageListBox
            // 
            this.messageListBox.CausesValidation = false;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 16;
            this.messageListBox.Location = new System.Drawing.Point(1063, 62);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(224, 484);
            this.messageListBox.TabIndex = 1;
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(1277, 561);
            this.entryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(10, 22);
            this.entryTextBox.TabIndex = 0;
            this.entryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryTextBox_KeyDown);
            // 
            // labelRowTable
            // 
            this.labelRowTable.AutoSize = true;
            this.labelRowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRowTable.Location = new System.Drawing.Point(19, 101);
            this.labelRowTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRowTable.Name = "labelRowTable";
            this.labelRowTable.Size = new System.Drawing.Size(125, 17);
            this.labelRowTable.TabIndex = 10;
            this.labelRowTable.Text = "row on the table";
            // 
            // labelCards1
            // 
            this.labelCards1.AutoSize = true;
            this.labelCards1.BackColor = System.Drawing.Color.Transparent;
            this.labelCards1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCards1.Location = new System.Drawing.Point(19, 493);
            this.labelCards1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCards1.Name = "labelCards1";
            this.labelCards1.Size = new System.Drawing.Size(112, 17);
            this.labelCards1.TabIndex = 11;
            this.labelCards1.Text = "cards player 1";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(1014, 21);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(100, 28);
            this.buttonRestart.TabIndex = 15;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(1131, 21);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(100, 28);
            this.QuitButton.TabIndex = 16;
            this.QuitButton.Text = "Quitter";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayers.Location = new System.Drawing.Point(76, 21);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(53, 16);
            this.labelPlayers.TabIndex = 17;
            this.labelPlayers.Text = "Players";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScore.Location = new System.Drawing.Point(76, 47);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(50, 16);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "Scores";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1283, 636);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelCards1);
            this.Controls.Add(this.labelRowTable);
            this.Controls.Add(this.entryTextBox);
            this.Controls.Add(this.messageListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "6 nimmt! (IUT version)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Label labelRowTable;
        private System.Windows.Forms.Label labelCards1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelScore;
    }
}

