using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
      private string inputWord;

      public RepeatCounter(string enterWord)
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

    // public class Program
    // {
    //   public static void Main()
    //   {
    //     Console.WriteLine("Enter Your Word.");
    //     string firstWord = Console.ReadLine();
    //     RepeatCounter wordCount = new RepeatCounter(firstWord);
    //   }
    // }

}
