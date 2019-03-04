using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICanDoThatGame
{
    class Game
    {
    

        public bool ChangeTurn(bool turn, Player currPlayer)
        {
            DialogResult dialogResult = MessageBox.Show($"Was {currPlayer.PlayerName} successful?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                currPlayer.UpdatePlayerScore(currPlayer);
                //MessageBox.Show(currPlayer.PlayerScore.ToString());
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            return turn = !turn;

        }

        /// <summary>
        /// This method returns true if there are no more turns left in the game, otherwise it returns false
        /// </summary>
        /// <param name="numTurns"></param>
        /// <returns>Boolean</returns>
        public bool OutOfTurns(int numTurns)
        {
            const int maxNumTurns = 10;
            if (numTurns > maxNumTurns)
            {
                return true;
            }
            return false;
        }

        public string CheckWinner(Player p1, Player p2)
        {
            if (p1.PlayerScore > p2.PlayerScore)
            {
                return p1.PlayerName;
            }
            else if (p2.PlayerScore > p1.PlayerScore)
            {
                return p2.PlayerName;
            }
            else
            {
                return "Nobody";
            }

        }

    }
}
