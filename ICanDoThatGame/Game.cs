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


    }
}
