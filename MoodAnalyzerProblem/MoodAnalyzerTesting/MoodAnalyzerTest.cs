using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyzer mood;
        [SetUp]
        public void Setup()
        {
            this.mood = new MoodAnalyzer();
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            //Arrange
            string output = "SAD";
            //Act
            string result = mood.AnalyzeMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            //Arrange
            string output = "HAPPY";
            //Act
            string result = mood.AnalyzeMood("I am in Any Mood");
            //Assert
            Assert.AreEqual(output, result);
        }
        [Test]
        public void WhenGivenNullMood_ReturnsHappyMessage()
        {
            //Arrange
            string output = "HAPPY";
            //Act
            string result = mood.AnalyzeMood("null");
            //Assert
            Assert.AreEqual(output, result);
        }
    }
}