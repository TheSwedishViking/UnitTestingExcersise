using packageCalculator.Models;
using Xunit;

namespace PackageManager.Tests
{
    public class PackageFixtureTests : IClassFixture<PackageFixture>
    {
        private readonly PackageFixture _fixture;
        private readonly packageCalculator.Calculation.Calculator _sut;

        public PackageFixtureTests(PackageFixture fixture)
        {
            _fixture = fixture;
            _sut = _fixture.Calcultor;
        }

        [Fact]
        public void Small_PackageUnderTwoKg_UnderThirtyCm_GetsCheapestPostage()
        {
            //A
            double expectedPrice = 29;
            CubicPackage smallPackage = new CubicPackage
            {
                LongSide = 20,
                ShortSide = 20,
                Weight = 1
            };

            //A
            var actualPrice = _sut.CalculateCube(smallPackage);
            //A
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Theory]
        [InlineData(5, 27, 5, 49)]
        [InlineData(8, 22, 10, 49)]
        [InlineData(3, 15, 10, 49)]
        public void Medium_PackageUnder10Kg_UnderThirtyCm_GetsMediumPostage(int weight, int longSide, int shortSide, int expectedPrice)
        {
            //A
            CubicPackage mediumPackage = new CubicPackage { Weight = weight, LongSide = longSide, ShortSide = shortSide };
            //A
            var actualPrice = _sut.CalculateCube(mediumPackage);
            //A
            Assert.Equal(actualPrice, expectedPrice);
        }


    }
}
