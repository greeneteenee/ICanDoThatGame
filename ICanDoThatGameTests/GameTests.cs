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
    }
}