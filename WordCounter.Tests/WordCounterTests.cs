using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTrackerTest
  {
    [TestMethod]
    public void GetWord_ReturnWord()
    {
      //Arrange
      string word = "pig";
      WordTrackerCounter wordCount = new WordTrackerCounter(firstWord);
      //Act
      string expectedResult = wordCount.GetWord();
      //Assert
      Assert.AreEqual(word, expectedResult);
    }

  }
}
