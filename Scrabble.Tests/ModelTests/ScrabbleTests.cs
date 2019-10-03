using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{

    [TestClass]
    public class ScrabbleScoreTests
    {
        [TestMethod]
        public void ScrabbleScore_SingleLetter_int()
        {
            string userInput = "a";
            int output = Scrabble.ScrabbleScore(userInput);


            Assert.AreEqual(output, 1);
        }
         [TestMethod]
         public void ScrabbleScore__MultiplelettersInWord_2()
         {
             string userInput = "at";
             int output = Scrabble.ScrabbleScore(userInput);
             Assert.AreEqual(output, 2);
         }
            
            [TestMethod]
         public void ScrabbleScore__MultiplelettersInWord_7()
         {
             string userInput = "plant";
             int output = Scrabble.ScrabbleScore(userInput);
             Assert.AreEqual(output, 7);
         }
    }

}
