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

            //ShortSide* LongSide *Weight + 100;
            if (LongSide <= 30)
            {
                switch (Weight)
                {
                    case double d when d <= 2:
                        return 29;
                    case double d when d > 2 && d <= 10:
                        return 49;
                    case double d when d > 10 && d <= 20:
                        return 79;
                    default:
                        return ShortSide * LongSide * Weight + 100;
                }
            }
            else
            {
                return ShortSide * LongSide * Weight + 100;
            }



        }
        public override string DimensionsPrinted => $"Kort sida: {ShortSide} cm, Lång sida: {LongSide} cm";
    }
}
