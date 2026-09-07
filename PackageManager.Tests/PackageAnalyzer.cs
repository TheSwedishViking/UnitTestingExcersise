using packageCalculator.Calculation;
using packageCalculator.Models;
using Xunit;

namespace PackageManager.Tests
{
    public class PackageAnalyzer
    {
        private readonly packageCalculator.Calculation.Calculator calculator = new Calculator();

        [Fact]
        public void MediumPackagePrice()
        {

            //Arrange
            CubicPackage cubicPackage = new CubicPackage
            {
                LongSide = 29,
                ShortSide = 10,
                Weight = 2.5
            };

            double excpectedPrice = 49;

            //Act
            double actualValue = calculator.CalculateCube(cubicPackage);


            //Assert

            Assert.Equal(excpectedPrice, actualValue);

        }



        [Fact]
        public void Cylinder()
        {

            //Arrange
            Cylinder cylinder = new Cylinder
            {
                Circumference = 70,
                Length = 5,
                Weight = 33
            };

            double excpectedPrice = 11550;

            //Act
            double actualValue = calculator.CalculateCylinder(cylinder);


            //Assert

            Assert.Equal(excpectedPrice, actualValue);

        }

    }
}
