using packageCalculator.Calculation;

namespace packageCalculator.Models
{
    public abstract class Shape
    {
        public double Weight { get; set; }

        public virtual double Price { get; set; }

        public virtual string DimensionsPrinted { get; set; }
    }

    public class Cylinder : Shape
    {


        public double Length { get; set; }
        public double Circumference { get; set; }

        public override double Price => CalculatePrice();



        public double CalculatePrice()
        {
            Calculation.Calculator calculator = new Calculator();
            return calculator.CalculateCylinder(this);
        }

        public override string DimensionsPrinted => $"Längd: {Length} cm, Omkrets: {Circumference} cm";
    }

    public class CubicPackage : Shape
    {
        public double ShortSide { get; set; }
        public double LongSide { get; set; }

        public override double Price => CalculatePrice();

        public double CalculatePrice()
        {
            Calculation.Calculator calculator = new Calculator();
            return calculator.CalculateCube(this);


        }
        public override string DimensionsPrinted => $"Kort sida: {ShortSide} cm, Lång sida: {LongSide} cm";
    }
}
