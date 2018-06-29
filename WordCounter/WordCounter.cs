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
      public int CountWord(string enterSentence)
      {
        int count = 0;
        string[] ArrayOfWords = enterSentence.Split(' ', '.', ',', '!', '?');
        for(int i = 0; i < ArrayOfWords.Length; i++)
        {
          if(String.Equals(inputWord, ArrayOfWords[i]))
          {
            count++;
          }
        }
        return count;
      }
    }

    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter Your Word.");
        string firstWord = Console.ReadLine();
        RepeatCounter wordCount = new RepeatCounter(firstWord);
        Console.WriteLine("Enter Your Sentence.");
        string enterSentence = Console.ReadLine();
        int wordSum = wordCount.CountWord(enterSentence);
        Console.WriteLine("Your Word Appears " + wordSum);
      }
    }

}
