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
    

        public void ChangeTurn(bool turn, Player currPlayer)
        {
            DialogResult dialogResult = MessageBox.Show($"Was {currPlayer.PlayerName} successful?", "", MessageBoxButtons.YesNo);
            turn = !turn;
        }

      
    }
}
