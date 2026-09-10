using Xunit;

namespace TDDtests
{
    public class IsbnTests
    {
        [Fact]
        public void IsbnNumber_ReturnsTrue()
        {
            //a
            var sut = new TDDprogram.IsbnCalculator();
            string number = "1234567891231";

            //a
            var result = sut.VerifyIsbnFormat(number);
            //a
            Assert.True(result);
        }

        [Theory]
        [InlineData("9780736687683", true)]
        [InlineData("9780593948194", true)]
        [InlineData("12345678912", false)]
        [InlineData("123456789", false)]

        public void IsbnNumbers_ThatIsTenOrThirteenNumbers_ReturnsTrue(string number, bool expected)
        {
            //a
            var sut = new TDDprogram.IsbnCalculator();

            //a
            var result = sut.VerifyIsbnFormat(number);
            //a
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("200005295522", true)]
        [InlineData("0105692922", true)]
        [InlineData("12345678912", false)]
        [InlineData("123456789", false)]

        public void PersonalNumbers_ThatIsTenOrTwelveNumbers_ReturnsTrue(string number, bool expected)
        {
            //a
            var sut = new TDDprogram.IsbnCalculator();

            //a
            var result = sut.VerifyPersonalNumberFormat(number);
            //a
            Assert.Equal(result, expected);
        }

    }
}
