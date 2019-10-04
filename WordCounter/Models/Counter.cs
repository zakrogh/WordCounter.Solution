using System;
namespace WordCounter.Models
{
  public class Counter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public Counter(string word, string sentence)
    {
      Word = word.ToLower();
      Sentence = sentence.ToLower();
    }
    public int CountWords()
    {
      int count = 0;
      string[] sentArr = Sentence.Split(" ", StringSplitOptions.None);
      for(int i = 0; i < sentArr.Length; i++)
      {
        if(sentArr[i] == Word)
          count++;
      }
      return count;
    }
  }
}
