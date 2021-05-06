using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class ScrabbleRules
  {
    // public static int A = 1;
    // public static int
    public static Dictionary<List<char>, int> LetterScores = new()
    {
      { new List<char> { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' }, 1 },
      { new List<char> { 'D', 'G' }, 2 },
      { new List<char> { 'B', 'C', 'M', 'P' }, 3 },
      { new List<char> { 'F', 'H', 'V', 'W', 'Y' }, 4 },
      { new List<char> { 'K' }, 5 },
      { new List<char> { 'J', 'X' }, 8 },
      { new List<char> { 'Q', 'Z' }, 10 },
    };
  }
  public class Word
  {
    public string value { get; }

    public Word(string input)
    {
      value = input;
    }

    public int GetScore()
    {
      int totalScore = 0;
      for (int i = 0; i < value.Length; i++)
      {
        char testLetter = Char.ToUpper(value[i]);
        foreach (KeyValuePair<List<char>, int> letterScoreSet in ScrabbleRules.LetterScores)
        {
          List<char> letters = letterScoreSet.Key;
          int score = letterScoreSet.Value;
          foreach (char letter in letters)
          {
            if (letter == testLetter)
            {
              totalScore += score;
              break;
            }
            Console.WriteLine(letter);
          }
          // do something with entry.Value or entry.Key
        }
        // for (int j = 0; j < ScrabbleRules.LetterScores.Count; j++)
        // {
        //    = ScrabbleRules.LetterScores[j]
        //   totalScore += ;
        // }
      }

      return 0;
    }
  }
}

// new Word()
// Word { myString: "foo" }

// Word myWord = new Word()
// -> Word {  }
// myWord.myString = "whatever"
// 

// letter
// scrabbleDictionary[letter] -> int
// scrabbleDictionary["A"] -> 1


