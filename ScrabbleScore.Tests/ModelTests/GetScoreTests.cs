using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOf_Word()
    {
      Word myWord = new("foo");
      Assert.AreEqual(typeof(Word), myWord.GetType());
    }
    [TestMethod]
    public void GetScore_ReturnsScoreForWord_Value()
    {
      Word myWord = new("hi");
      Assert.AreEqual(5, myWord.GetScore());
    }

  }

}



// Add README
//assign values for letters
// an array for the values of the letters
// a list to push the user input
// loop through

//it will take a user's input word and break it down into an array or list with each letter seperated. 
// it will loop throught the list/array and push a value to an empty list that corrisponds with the letter
// then it will add the values of all the list items together.
