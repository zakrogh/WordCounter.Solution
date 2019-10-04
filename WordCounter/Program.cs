using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Word Counter!");
      Console.WriteLine("Enter the word you wish to count:");
      string word = Console.ReadLine();
      Console.WriteLine("Enter the sentence you wish to search:");
      string sentence = Console.ReadLine();
      Counter myCounter = new Counter(word, sentence);
      Console.WriteLine("I found {0} instances of the word {1} in your sentence.", myCounter.CountWords(), word);
    }
  }
}
