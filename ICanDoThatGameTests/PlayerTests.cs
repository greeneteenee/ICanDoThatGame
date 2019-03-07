using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICanDoThatGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void PlayerNameValidMethod_NameNull_ReturnFalse()
        {
            //Arrange
            Player player = new Player(null);
            player.PlayerName = null;
            int maxLength = 12;
            bool expectedResponse = false;
            
            //Act
            bool result = player.PlayerNameValid(player.PlayerName, maxLength);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

        [TestMethod()]
        public void PlayerNameValidMethod_NameEmptyString_ReturnFalse()
        {
            //Arrange
            Player player = new Player("");
            player.PlayerName = "";
            int maxLength = 12;
            bool expectedResponse = false;

            //Act
            bool result = player.PlayerNameValid(player.PlayerName, maxLength);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

        [TestMethod()]
        public void PlayerNameValidMethod_NameWhitespace_ReturnFalse()
        {
            //Arrange
            Player player = new Player("           ");
            player.PlayerName = "          ";
            int maxLength = 12;
            bool expectedResponse = false;

            //Act
            bool result = player.PlayerNameValid(player.PlayerName, maxLength);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

        [TestMethod()]
        public void PlayerNameValidMethod_NameLongerThanMaxAllowed_ReturnFalse()
        {
            //Arrange
            Player player = new Player("1234567890123");
            player.PlayerName = "1234567890123";
            int maxLength = 12;
            bool expectedResponse = false;

            //Act
            bool result = player.PlayerNameValid(player.PlayerName, maxLength);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

        [TestMethod()]
        public void PlayerNameValidMethod_NameValid_ReturnTrue()
        {
            //Arrange
            Player player = new Player("Thing 1");
            player.PlayerName = "Thing 1";
            int maxLength = 12;
            bool expectedResponse = true;

            //Act
            bool result = player.PlayerNameValid(player.PlayerName, maxLength);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

    }

}


