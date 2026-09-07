namespace packageCalculator.Calculation
{
    public class Calculator
    {
        public double CalculateCube(Models.CubicPackage package)
        {
            //ShortSide* LongSide *Weight + 100;
            if (package.LongSide <= 30)
            {
                switch (package.Weight)
                {
                    case double d when d <= 2:
                        return 29;
                    case double d when d > 2 && d <= 10:
                        return 49;
                    case double d when d > 10 && d <= 20:
                        return 79;
                    default:
                        return package.ShortSide * package.LongSide * package.Weight + 100;
                }
            }
            else
            {
                return package.ShortSide * package.LongSide * package.Weight + 100;
            }
        }

        public double CalculateCylinder(Models.Cylinder cylinder)
        {
            return cylinder.Circumference * cylinder.Length * cylinder.Weight;



        }


    }
}
