using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; private set; } = 0;

        
        public int UpdatePlayerScore(int score)
        {
            return score + 1;
        }

    }
}
