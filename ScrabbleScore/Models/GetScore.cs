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
    public string value { get; }

    public Word(string input)
    {
      value = input;
    }

    public int GetScore()
    {
      for (int index = 0; index < value.Length; index++)
      {
        char letter = value[index];

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


