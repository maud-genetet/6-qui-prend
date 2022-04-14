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
        List<CardView> cardViewsPlayer = new List<CardView>(10);
        List<CardView> cardViewsChooseByPlayers = new List<CardView>(10);
        List<int> scores = new List<int>(10);
        Rectangle rowHover = Rectangle.Empty;
        CardView cardView;
        int numberOfRow;
        Boolean chooseRow = false;
        #endregion
        #region Constructor

        internal MainWindow(GameController gameController)
        {
            InitializeComponent();
            this.gameController = gameController;
            gameController.StartMeUp(this);
            DoubleBuffered = true;
        }
        #endregion
        #region Methods called by the controller

        internal void DisplayCardsAfterRubber(List<int> cardsChosen)
        {
            cardsChosen.Sort();
            int a = 1;
            foreach (int card in cardsChosen)
            {
                CardView cardView = new CardView
                {
                    Position = new System.Drawing.Point((int)(a * 55), (int)(570)),
                    Card = card
                };
                cardViewsChooseByPlayers.Add(cardView);
                a++;
            }
            Refresh();
            MessageBox.Show("All players are choose a card");
        }

        /// <summary>
        /// Method called to display the cards of a player in dedicated controls.
        /// </summary>
        /// <param name="player">The player selected.</param>
        /// <param name="cards">The cards to display.</param>

        internal void DrawHandOfPlayer(List<int> cards, int player, bool onView)
        {
            if (onView)
            {
                chooseRow = false;
                labelCards1.Text = "Hand of the player : " + (int)(player + 1);
                cardViewsChooseByPlayers.Clear();
            }
            else
            {
                chooseRow = true;
                labelCards1.Text = "Player " + (int)(player + 1 ) + " please, chose a row.";
            }
            cardViewsPlayer.Clear();
            Refresh();
            MessageBox.Show("Player " + (int)(player + 1) + ", this is your turn.");
            int i = 1;
            foreach (int card in cards)
            {
                CardView cardView = new CardView
                {
                    Position = new System.Drawing.Point((int)(i * 55), (int)(430)),
                    Card = card
                };
                cardViewsPlayer.Add(cardView);
                i++;
            }
            Refresh();
        }

        /// <summary>
        /// Method called to display the score in dedicated controls.
        /// </summary>
        /// <param name="player">The player selected.</param>
        /// <param name="score">The score of the player.</param>
        internal void UpdateScore(List<int> scoresJoueurs)
        {
            scores = scoresJoueurs;
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
                        Position = new System.Drawing.Point((int)(i * 55), (int)(numberRow * 60 + 55)),
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
            /*if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Or beep.
                gameController.Interpret(entryTextBox.Text);
                entryTextBox.Text = "";
            }*/
        }
        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            //On garde !!!//
            int splitX = messageListBox.Left - 10;
            e.Graphics.DrawLine(Pens.Black, new Point(splitX, 0), new Point(splitX, Height));

            Rectangle haut = new Rectangle(0, 0, this.ClientSize.Width, 60);
            Rectangle bas = new Rectangle(0, this.ClientSize.Height-140, this.ClientSize.Width, 140);
            Rectangle basHaut = new Rectangle(0, this.ClientSize.Height - 280, this.ClientSize.Width, 140);

            // Draw rectangle to screen.
            e.Graphics.FillRectangle(Brushes.DarkRed, haut);
            e.Graphics.FillRectangle(Brushes.PeachPuff, bas);
            e.Graphics.FillRectangle(Brushes.LightSalmon, basHaut);
            //////////
            ///

            int i = 1;
            foreach (int score in scores)
            {
                e.Graphics.DrawString(i.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.White, 40 * i + 100, 7);
                e.Graphics.DrawString(score.ToString() , new Font("Arial", 15, FontStyle.Regular), Brushes.White, 40 * i + 100, 32);
                i++;
            }

            e.Graphics.FillRectangle(Brushes.OliveDrab, rowHover);

            foreach (List<CardView> cartRow in cardViewsRows)
            {
                foreach(CardView cart in cartRow)
                {
                    cart.Draw(e);
                }
            }
            foreach (CardView card in cardViewsPlayer)
            {
                card.Draw(e);
            }
            foreach (CardView card in cardViewsChooseByPlayers)
            {
                card.Draw(e);
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

        private void MainWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (!chooseRow)
            {
                Boolean inCard = false;
                foreach (CardView card in cardViewsPlayer)
                {
                    if (card.Contains(e.Location))
                    {
                        cardView = card;
                        inCard = true;
                    }
                }
                if (inCard)
                {
                    gameController.Interpret(cardView.Card.ToString());
                }
            }
            else
            {
                Boolean inRow = false;
                int i = 0;
                foreach (List<CardView> row in cardViewsRows)
                {
                    if (row[0].Position.Y < e.Location.Y && row[0].Position.Y+row[0].Taille.Height > e.Location.Y)
                    {
                        inRow = true;
                        numberOfRow = i;
                    }
                    i++;
                }
                if (inRow)
                {
                    gameController.Interpret(numberOfRow.ToString());
                }
            }
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            rowHover = Rectangle.Empty;
            if (!chooseRow)
            {
                foreach (CardView card in cardViewsPlayer)
                {
                    if (card.Contains(e.Location))
                    {
                        card.Position = new Point(card.Position.X, 420);
                    }
                    else
                    {
                        card.Position = new Point(card.Position.X, 430);
                    }
                }
            }
            else
            {
                foreach (List<CardView> row in cardViewsRows)
                {
                    if (row[0].Position.Y < e.Location.Y && row[0].Position.Y + row[0].Taille.Height > e.Location.Y)
                    {
                        rowHover = new Rectangle(20, row[0].Position.Y-2, this.ClientSize.Width-40, row[0].Taille.Height+4);
                    }
                }
            }
            Refresh();
        }
    }
}
