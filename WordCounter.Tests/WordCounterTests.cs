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
    [TestMethod]
    public void CountWord_ReturnCount()
    {
      //Arrange
      string firstWord = "Salmon";
      string enterSentence = "Salmon";
      int outPut = 1;
      RepeatCounter wordCount = new RepeatCounter(firstWord);
      //Act
      int expectedResult = wordCount.CountWord(enterSentence);
      //Assert
      Assert.AreEqual(outPut, expectedResult);
    }
    [TestMethod]
    public void CountWord2_ReturnCount()
    {
      //Arrange
      string firstWord = "Pig";
      string enterSentence = "Two little Pig Pig in the barn";
      int outPut = 2;
      RepeatCounter wordCount = new RepeatCounter(firstWord);
      //Act
      int expectedResult = wordCount.CountWord(enterSentence);
      //Assert
      Assert.AreEqual(outPut, expectedResult);
    }
    [TestMethod]
    public void CountWord3_ReturnCount()
    {
      //Arrange
      string firstWord = "Fish";
      string enterSentence = "Fish Fish Fish in the sea Fishery";
      int outPut = 3;
      RepeatCounter wordCount = new RepeatCounter(firstWord);
      //Act
      int expectedResult = wordCount.CountWord(enterSentence);
      //Assert
      Assert.AreEqual(outPut, expectedResult);
    }
  }
}
