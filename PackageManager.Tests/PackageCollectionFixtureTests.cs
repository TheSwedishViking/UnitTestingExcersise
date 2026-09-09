using Xunit;

namespace PackageManager.Tests
{
    [Collection("Package collection")]
    public class PackageCollectionFixtureTests
    {
        private readonly PackageFixture _fixture;
        private readonly packageCalculator.Calculation.Calculator _sut;

        public PackageCollectionFixtureTests(PackageFixture fixture)
        {
            _fixture = fixture;
            _sut = _fixture.Calcultor;
        }


        [Theory]
        [InlineData(1, 20, 10, 29)]
        [InlineData(3, 27, 22, 49)]
        [InlineData(13, 29, 15, 79)]
        [InlineData(400, 50, 40, 800100)]
        public void PackagePostageClasses_GivesCorrect_Pricing(int weight, int longside, int shortside, int price)
        {
            //A
            packageCalculator.Models.CubicPackage package = new packageCalculator.Models.CubicPackage
            {
                Weight = weight,
                LongSide = longside,
                ShortSide = shortside
            };
            //A
            var actualPrice = _sut.CalculateCube(package);

            //A
            Assert.Equal(price, actualPrice);
        }




    }
}
