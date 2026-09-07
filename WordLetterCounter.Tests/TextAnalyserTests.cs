using Xunit;

namespace WordLetterCounter.Tests
{
    public class TextAnalyserTests
    {
        private readonly TextAnalyzer _textAnalyzer = new TextAnalyzer();


        [Fact]
        public void Count_WordsFromSentence_Returns5()
        {
            // Arrange

            string test = "";
            int expected = 0;
            //Act
            var result = _textAnalyzer.CountWords(test);
            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Count_LettersFromSentence_Returns21()
        {
            // Arrange
            string test = "I am on the highway to hell";
            int expected = 21;

            //Act

            var result = _textAnalyzer.CountLetters(test);

            // Assert

            Assert.Equal(expected, result);
        }
    }
}
