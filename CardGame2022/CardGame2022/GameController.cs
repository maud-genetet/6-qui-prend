using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    /// <summary>
    /// The game controller object allows a logic (GameLogic object) and view (MainWindow object) to communicate
    /// </summary>
    internal class GameController
    {
        #region Association attributes
        private readonly GameLogic gameLogic;
        private MainWindow mainWindow;
        #endregion
        #region Properties accessed by the logic
        /// <summary>
        /// The integer (checked) entered by the current user for the current interaction.
        /// </summary>
        internal int CurrentInt { get; private set; }
        /// <summary>
        /// The possible integer inputs to choose from selectable for the user for the next interaction.
        /// </summary>
        internal List<int> AllowedInput { get; set; }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructor. Creates a new game logic.
        /// </summary>
        /// <param name="numberOfPlayers">The number of players (1-10) for the new game.</param>
        internal GameController(int numberOfPlayers)
        {
            gameLogic = new GameLogic(numberOfPlayers, this);
        }
        #endregion
        #region Methods called by the logic or view
        /// <summary>
        /// Method called by the logic when the state of the game (cards on the table) should be displayed.
        /// </summary>
        /// <param name="allRows">Each row of cards as a list of list of cards.</param>
        internal void UpdateState(List<List<int>> allRows)
        {
            List<int> scores = new List<int>();
            for (int i=0; i<allRows.Count; i++)
            mainWindow.UpdateRow(allRows);
            Boolean end = false;
            for (int i = 0; i < gameLogic.GetNumberOfPlayers(); i++)
            {
                if (gameLogic.GetCurrentScoreForPlayer(i) >= 66)
                {
                    end = true;
                }
                scores.Add(gameLogic.GetCurrentScoreForPlayer(i));
            }
            if (end) {
                DisplayRubberScores(scores);
            }
            mainWindow.UpdateScore(scores);
        }
        /// <summary>
        /// Method called when a rubber has ended to display the scores.
        /// </summary>
        /// <param name="playersScores">The list of all scores.</param>
        internal void DisplayRubberScores(List<int> playersScores)
        {
            List<String> scores = new List<String>();
            
            for (int i=0; i<playersScores.Count; i++)
            {
                scores.Add("Player " + (i + 1) + ": " + playersScores[i]);
            }
            endGame end = new endGame(scores);
           end.ShowDialog();
            RestartGame();
        }
        /// <summary>
        /// Method used by the window when a command is entered.
        /// </summary>
        /// <param name="text">The command entered, shoukd be an int within AllowedInput.</param>
        internal void Interpret(string text)
        {
            if (int.TryParse(text, out int res))
            {
                if (AllowedInput.Contains(res))
                {
                    CurrentInt = res;
                    AllowedInput = null;
                    gameLogic.ActOnce();
                }
            }
        }
        /// <summary>
        /// Method called to start the game.
        /// </summary>
        /// <param name="mainWindow">The window (view) to use for this game.</param>
        internal void StartMeUp(MainWindow mainWindow)
        {
            this.mainWindow= mainWindow;
            gameLogic.ActOnce();
        }
        /// <summary>
        /// Method used by the logic to say that the game has ended.
        /// </summary>
        internal void DisplayGameOverMessage()
        {
            AllowedInput = new List<int> { 0 };
        }
        /// <summary>
        /// Method used to prompt player "player" to select a card from their hand
        /// </summary>
        /// <param name="player">The player to select</param>
        internal void AskPlayerForCard(int player)
        {
            DisplayPlayerHand(player);
        }
        /// <summary>
        /// Method called to display the cards selected by players
        /// </summary>
        /// <param name="cardsSelectedByPlayers">The cards arranged by player</param>
        internal void DisplayCardsSelected(Dictionary<int, int> cardsSelectedByPlayers)
        {
            List<int> cards = new List<int>(10);
            foreach (int player in cardsSelectedByPlayers.Keys)
            {
                cards.Add(cardsSelectedByPlayers[player]);
            }
            mainWindow.DisplayCardsAfterRubber(cards);
            gameLogic.ActOnce();
        }
        /// <summary>
        /// Method called to end a rubber
        /// </summary>
        internal void DisplayRubberOver()
        {
            gameLogic.ActOnce();
        }

        /// <summary>
        /// Method used to reset the input whenever necessary
        /// </summary>
        internal void ResetInput() => CurrentInt = -1;
        /// <summary>
        /// Method used to prompt a player to choose a row because their card was too low.
        /// </summary>
        /// <param name="player">The player involved.</param>
        internal void AskPlayerForRow(int player)
        {
            mainWindow.DrawHandOfPlayer(new List<int>(), player, false);
        }
        #endregion
        #region Private methods

        private void DisplayPlayerHand(int player)
        {
            List<int> cards = gameLogic.GetCurrentHandForPlayer(player);
            cards.Sort();
            mainWindow.DrawHandOfPlayer(cards, player, true);
        }
        #endregion
        #region Methods by me
        /// <summary>
        /// Restart the Game
        /// </summary>
        internal void RestartGame()
        {
            gameLogic.RestartGameLogic();
        }
        /// <summary>
        /// Return the number of players
        /// </summary>
        /// <returns>int</returns>
        internal int GetNumberOfPlayers()
        {
            return gameLogic.GetNumberOfPlayers();
        }
        #endregion
    }
}
