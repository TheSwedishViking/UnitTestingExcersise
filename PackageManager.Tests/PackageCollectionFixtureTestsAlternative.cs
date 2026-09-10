using packageCalculator.Models;
using PackageManager.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PackageManager.Tests
{
    [Collection("Package collection")]
    public class PackageCollectionFixtureTestsAlternative
    {
        private readonly PackageFixture _fixture;
        private readonly packageCalculator.Calculation.Calculator _sut;
        public PackageCollectionFixtureTestsAlternative(PackageFixture fixture)
        {
            _fixture = fixture;
            _sut = fixture.Calcultor;
        }

        [Theory]
        [ClassData(typeof(ExampleDataService))]
        public void FromJson_PackageSizes_ReturnsExpected_PostagePriceClass(CubicPackage package, int expectedPrice)
        {
            var actualPrice = _sut.CalculateCube(package); //Act
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Theory]
        [MemberData(nameof(GetExamplePackages))] //Arrange
        public void DifferentPackageWeight_UnderThirtyCm_Returns_DifferentExpected_PostagePriceClasses(CubicPackage package, int expectedPrice)
        {
            var actualPrice = _sut.CalculateCube(package); //Act

            Assert.Equal(expectedPrice, actualPrice);
        }


        public static IEnumerable<object[]> GetExamplePackages()
        {
            yield return new object[] { new CubicPackage { Weight = 1, ShortSide = 10, LongSide = 20 }, 29 };
            yield return new object[] { new CubicPackage { Weight = 5, ShortSide = 10, LongSide = 20 }, 49 };
            yield return new object[] { new CubicPackage { Weight = 19, ShortSide = 10, LongSide = 20 }, 79 };

        }

    }
}
