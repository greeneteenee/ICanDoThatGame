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
            int maxTurns = 10;
            int numTurns = 5;

            //Act
            if(numTurns < maxTurns)
            {
                bool result = true;
            }

        }
    }
}