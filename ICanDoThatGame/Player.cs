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
            
            //if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Player name cannot be blank. Please enter Player name");
            //if (string.IsNullOrEmpty(name)) throw new ArgumentException("Player name cannot be blank. Please enter Player name");
            

        }

        //PROPERTIES
        public string PlayerName { get; set; }
        public int PlayerScore { get; private set; } = 0;
        public int MaxPlayerNameLength { get; set; } = 12;

        //METHOD(S)
       
        /// <summary>
        /// This method takes a Player object and adds 1 point to the player's score
        /// </summary>
        /// <param name="currPlayer"></param>
        public void UpdatePlayerScore(Player currPlayer)
        {
            currPlayer.PlayerScore += 1;
        }

        /// <summary>
        /// This method takes a player name (string) and makes sure it's not null, not empty, not whitespace and not longer than teh maximum allowed string length
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxLength"></param>
        /// <returns>Returns true if player name (string) is valid, otherwise returns false</returns>
        public bool PlayerNameValid(string name, int maxLength)
        {
            //name.Trim();
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            else if (name.Length > maxLength)
            {
                return false;
            }
            return true;
        }

    }
}
