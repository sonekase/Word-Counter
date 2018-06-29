using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetWord_ReturnWord()
    {
      //Arrange
      string firstWord = "salmon";
      RepeatCounter wordCount = new RepeatCounter(firstWord);
      //Act
      string expectedResult = wordCount.GetWord();
      //Assert
      Assert.AreEqual(firstWord, expectedResult);
    }

  }
}
