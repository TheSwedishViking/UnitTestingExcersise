using Xunit;

namespace WordLetterCounter.Tests
{
    public class TextAnalyserTests
    {
        private readonly TextAnalyzer _textAnalyzer = new TextAnalyzer();


        [Fact]
        public void Count_LettersFromSentence_Returns5()
        {
            // Arrange

            string test = "Jag gillar glass o öl";
            int expected = 12;
            //Act
            var result = _textAnalyzer.CountLetters(test);
            // Assert

            Assert.Equal(25, result);
        }
    }
}
