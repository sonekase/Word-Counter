using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class WordTracker
    {
      private string inputWord;

      public WordTrackerCounter(string enterWord)
      {
        inputWord = enterWord;
      }
      public string GetWord()
      {
        return inputWord;
      }
    }

    // public WordTracker(string enterWord)
    // {
    //
    // }

    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter Your Word.");
        string firstWord = Console.ReadLine();
        WordTrackerCounter wordCount = new WordTrackerCounter(firstWord);
      }
    }

}
