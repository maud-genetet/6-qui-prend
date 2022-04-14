namespace CardGame2022
{
    partial class Menu
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.nbPlayerLabel = new System.Windows.Forms.Label();
            this.QuitBouton = new System.Windows.Forms.Button();
            this.numericUpDownNbJoueurs = new System.Windows.Forms.NumericUpDown();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJoueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Firebrick;
            this.PlayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayButton.Location = new System.Drawing.Point(175, 152);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(122, 32);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Jouer";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // nbPlayerLabel
            // 
            this.nbPlayerLabel.AutoSize = true;
            this.nbPlayerLabel.Location = new System.Drawing.Point(53, 201);
            this.nbPlayerLabel.Name = "nbPlayerLabel";
            this.nbPlayerLabel.Size = new System.Drawing.Size(102, 13);
            this.nbPlayerLabel.TabIndex = 1;
            this.nbPlayerLabel.Text = "Nombre de joueurs :";
            // 
            // QuitBouton
            // 
            this.QuitBouton.BackColor = System.Drawing.Color.Firebrick;
            this.QuitBouton.Location = new System.Drawing.Point(173, 281);
            this.QuitBouton.Name = "QuitBouton";
            this.QuitBouton.Size = new System.Drawing.Size(122, 32);
            this.QuitBouton.TabIndex = 3;
            this.QuitBouton.Text = "Quitter";
            this.QuitBouton.UseVisualStyleBackColor = false;
            this.QuitBouton.Click += new System.EventHandler(this.QuitBouton_Click);
            // 
            // numericUpDownNbJoueurs
            // 
            this.numericUpDownNbJoueurs.Location = new System.Drawing.Point(175, 199);
            this.numericUpDownNbJoueurs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNbJoueurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNbJoueurs.Name = "numericUpDownNbJoueurs";
            this.numericUpDownNbJoueurs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNbJoueurs.TabIndex = 4;
            this.numericUpDownNbJoueurs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.Title.Location = new System.Drawing.Point(171, 111);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(134, 24);
            this.Title.TabIndex = 5;
            this.Title.Text = "6 Qui Prend !";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.numericUpDownNbJoueurs);
            this.Controls.Add(this.QuitBouton);
            this.Controls.Add(this.nbPlayerLabel);
            this.Controls.Add(this.PlayButton);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJoueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label nbPlayerLabel;
        private System.Windows.Forms.Button QuitBouton;
        private System.Windows.Forms.NumericUpDown numericUpDownNbJoueurs;
        private System.Windows.Forms.Label Title;
    }
}