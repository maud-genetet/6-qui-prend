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
    /// <summary>
    /// A window that displays the view and UI for a game
    /// </summary>
    internal partial class MainWindow : Form
    {
        #region Association attributes
        private readonly GameController gameController;
        List<List<CardView>> cardViewsRows = new List<List<CardView>>(4);
        List<List<CardView>> cardViewsPlayer = new List<List<CardView>>(10);
        #endregion
        #region Constructor

        internal MainWindow(GameController gameController)
        {
            InitializeComponent();
            this.gameController = gameController;
            gameController.StartMeUp(this);
            playerOneHandLabel.Visible =
            playerOneScoreLabel.Visible =
            playerTwoHandLabel.Visible =
            playerTwoScoreLabel.Visible =
            rowOneLabel.Visible =
            rowTwoLabel.Visible =
            rowThreeLabel.Visible =
            rowFourLabel.Visible = true;
        }
        #endregion
        #region Methods called by the controller
        /// <summary>
        /// Method called to display the cards of a player in dedicated controls.
        /// </summary>
        /// <param name="player">The player selected.</param>
        /// <param name="cards">The cards to display.</param>
        internal void UpdateHand(int player, List<int> cards)
        {
            switch (player)
            {
                case 0:
                    playerOneHandLabel.Text = CardsHandling.ListOfCardsToString(cards);
                    break;
                case 1:
                    playerTwoHandLabel.Text = CardsHandling.ListOfCardsToString(cards);
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// Method called to display the score in dedicated controls.
        /// </summary>
        /// <param name="player">The player selected.</param>
        /// <param name="score">The score of the player.</param>
        internal void UpdateScore(int player, int score)
        {
            switch (player)
            {
                case 0:
                    playerOneScoreLabel.Text = score.ToString();
                    break;
                case 1:
                    playerTwoScoreLabel.Text = score.ToString();
                    break;
                default:
                    return;
            }
        }
        /// <summary>
        /// Method called by the controler whenever some text should be displayed
        /// </summary>
        /// <param name="s"></param>
        internal void WriteLine(string s)
        {
            List<string> strs = s.Split('\n').ToList();
            strs.ForEach(str => messageListBox.Items.Add(str));
            if (messageListBox.Items.Count > 0)
            {
                messageListBox.SelectedIndex = messageListBox.Items.Count - 1;
            }
            messageListBox.Refresh();
        }
        /// <summary>
        /// Method called by the controler to update one row of cards on the table
        /// </summary>
        /// <param name="cards">The list of list of cards</param>
        internal void UpdateRow(List<List<int>> cards)
        {
            cardViewsRows.Clear();
            int numberRow = 1;
            foreach (var cardRow in cards)
            {
                int i = 1;
                List<CardView> listCard = new List<CardView>();
                foreach (int card in cardRow)
                {
                    CardView cardView = new CardView
                    {
                        Position = new System.Drawing.Point((int)(i * 55), (int)(numberRow * 60)),
                        Card = card
                    };
                    listCard.Add(cardView);
                    i++;
                }
                numberRow++;
                cardViewsRows.Add(listCard);
            }
            Refresh();
        }

        #endregion
        #region Event handling
        private void EntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Or beep.
                gameController.Interpret(entryTextBox.Text);
                entryTextBox.Text = "";
            }
        }
        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            //On garde !!!//
            int splitX = messageListBox.Left - 10;
            e.Graphics.DrawLine(Pens.Black, new Point(splitX, 0), new Point(splitX, Height));
            //////////
            ///

            foreach (List<CardView> cartRow in cardViewsRows)
            {
                foreach(CardView cart in cartRow)
                {
                    cart.Draw(e);
                }
            }
        }
        #endregion

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            gameController.RestartGame();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
