using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    public class Player
    {
       
        //CONSTRUCTOR(S): player must have PlayerName
        public Player(string name)
        {
            
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Player name cannot be blank. Please enter Player name");
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Player name cannot be blank. Please enter Player name");
            

        }

        //PROPERTIES
        public string PlayerName { get; set; }
        public int PlayerScore { get; private set; } = 0;
        public int MaxPlayerNameLength { get; set; } = 12;

        //METHOD(S)
        public void UpdatePlayerScore(Player currPlayer)
        {
            currPlayer.PlayerScore += 1;
        }              
    }
}
