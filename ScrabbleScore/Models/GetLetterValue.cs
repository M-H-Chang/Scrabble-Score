using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class ScrabbleRules
  {
    // public static int A = 1;
    // public static int
    readonly static Dictionary<List<char>, int> LetterScores = new()
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
    // string[] valueOne = { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" };
    // string[] valueTwo = { "D", "G" };
    // string[] valueThree = { "B", "C", "M", "P" };
    // string[] valueFour = { "F", "H", "V", "W", "Y" };
    // string[] valueFive = { "K" };
    // string[] valueEight = { "J", "X" };
    // string[] valueTen = { "Q", "Z" };

    public static int GetLetterValue(string input)
    {
      string userInput = input;
      for (int index = 0; index < userInput.Length; index++)
      {
        string letter = userInput.Substring(index, 1);
        if (letter == "A")
        {
          return 1;
        }
      }
    }
  }
}

// letter
// scrabbleDictionary[letter] -> int
// scrabbleDictionary["A"] -> 1


