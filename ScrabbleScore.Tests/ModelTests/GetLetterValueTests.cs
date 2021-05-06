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
    public void GetLetterValue_AString_True()
    {
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void
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
