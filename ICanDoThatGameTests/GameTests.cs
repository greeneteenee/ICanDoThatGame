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
    public class GameTests
    {
        [TestMethod()]
        public void OutOfTurnsTestMethod_NumTurnsLessThanMax_ReturnFalse()
        {
            //Arrange
            int numTurns = 5;
            bool expectedResponse = false;
            Game game = new Game();

            //Act
            bool result = game.OutOfTurns(numTurns);

            //Assert
            Assert.AreEqual(result, expectedResponse);

        }

        [TestMethod()]
        public void OutOfTurnsTestMethod_NumTurnGreaterThanMax_ReturnTrue()
        {
            //Arrange
            int numTurns = 31;
            bool expectedResponse = true;
            Game game = new Game();

            //Act
            bool result = game.OutOfTurns(numTurns);

            //Assert
            Assert.AreEqual(result, expectedResponse);

        }

        [TestMethod()]
        public void OutOfTurnsTestMethod_NegativeNumTurns_ThrowsArgumentOutofRangeException()
        {
            //Arrange
            int numTurns = -1;
            Game game = new Game();

            //Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => game.OutOfTurns(numTurns));

        }

        [TestMethod()]
        public void CheckWinnerMethod_P1ScoreGreaterThanP2Score_ReturnP1Name()
        {
            //Arrange
            string expectedResponse = "Thing 1";

            Player p1 = new Player("Thing 1");
            p1.PlayerName = "Thing 1";
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);

            Player p2 = new Player("Thing 2");
            p2.PlayerName = "Thing 2";
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            Game game = new Game();

            //Act
            string result = game.CheckWinner(p1, p2);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }


        [TestMethod()]
        public void CheckWinnerMethod_P2ScoreGreaterThanP1Score_ReturnP2Name()
        {
            //Arrange
            string expectedResponse = "Thing 2";

            Player p1 = new Player("Thing 1");
            p1.PlayerName = "Thing 1";
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
           

            Player p2 = new Player("Thing 2");
            p2.PlayerName = "Thing 2";
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            Game game = new Game();

            //Act
            string result = game.CheckWinner(p1, p2);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }


        [TestMethod()]
        public void CheckWinnerMethod_P1ScoreEqualToP2Score_ReturnEverybody()
        {
            //Arrange
            string expectedResponse = "Everybody";

            Player p1 = new Player("Thing 1");
            p1.PlayerName = "Thing 1";
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            p1.UpdatePlayerScore(p1);
            
            Player p2 = new Player("Thing 2");
            p2.PlayerName = "Thing 2";
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            p2.UpdatePlayerScore(p2);
            Game game = new Game();

            //Act
            string result = game.CheckWinner(p1, p2);

            //Assert
            Assert.AreEqual(result, expectedResponse);
        }

    }
}