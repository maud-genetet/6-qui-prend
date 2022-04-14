using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    public partial class Menu : Form
    {
        public Menu(int nbPlayers)
        {
            InitializeComponent();
            numericUpDownNbJoueurs.Value = nbPlayers;
        }


        public int getNbPlayers() => (int)numericUpDownNbJoueurs.Value;
        private void PlayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void QuitBouton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
