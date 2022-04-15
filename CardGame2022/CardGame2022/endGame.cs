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
    public partial class endGame : Form
    {
        public endGame(List<String> s)
        {
            InitializeComponent();
            foreach (String s2 in s)
            {
                listBoxScorePlayers.Items.Add(s2);
            }
        }

        void RestartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
