﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    class Player
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; private set; }

        
        public int UpdatePlayerScore(int score)
        {
            return score + 1;
        }

    }
}
