using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Basic init, do not change
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion
            GameController gameController;
            int nbJoueurs = 0;
            Menu menu = new Menu(2);
            if (menu.ShowDialog() == DialogResult.OK)
            {
                nbJoueurs = menu.getNbPlayers();
            }
            gameController = new GameController(nbJoueurs);   // New GameController, GameLogic




            Application.Run(new MainWindow(gameController)); // New MainWindow
        }
    }
}

