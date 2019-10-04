using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void Counter_IsWordAndSentenceStored_True()
    {
      Counter testCounter = new Counter("word", "this is a sentence");
      Assert.AreEqual(testCounter.Word, "word");
      Assert.AreEqual(testCounter.Sentence, "this is a sentence");
    }
    [TestMethod]
    public void Counter_OneWordSentenceCount()
    {
      Counter testCounter = new Counter("word", "word");
      Assert.AreEqual(testCounter.CountWords(), 1);
    }
    [TestMethod]
    public void Counter_MultipleWordSentenceCount()
    {
      Counter testCounter = new Counter("word", "word sentence word containing three word");
      Assert.AreEqual(testCounter.CountWords(), 3);
    }
    [TestMethod]
    public void Counter_NoPartialWordMatch()
    {
      Counter testCounter = new Counter("word", "words");
      Assert.AreEqual(testCounter.CountWords(), 0);
    }
  }
}
