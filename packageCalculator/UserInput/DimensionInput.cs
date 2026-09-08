using packageCalculator.Models;

namespace packageCalculator.UserInput
{
    public class DimensionInput
    {

        public Shape InputDimesion(Shape shape)
        {
            switch (shape)
            {
                case CubicPackage cube:
                    shape = CubeInput(cube);
                    return shape;

                case Cylinder cylinder:
                    shape = CylinderInput(cylinder);
                    return shape;
                default:
                    {
                        throw new ArgumentException("Invalid shape type");
                    }
            }
        }
        public CubicPackage CubeInput(CubicPackage cube)
        {
            Console.WriteLine("Kortisda längd? (cm)");
            double shortSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Långsida längd? (cm)");
            double longSide = Convert.ToDouble(Console.ReadLine());

            cube.ShortSide = shortSide;
            cube.LongSide = longSide;

            return cube;
        }
        public Cylinder CylinderInput(Cylinder cylinder)
        {
            Console.WriteLine("Cylinder längd? (cm)");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cylinder omkrets? (cm)");
            double circumference = Convert.ToDouble(Console.ReadLine());

            cylinder.Length = length;
            cylinder.Circumference = circumference;

            return cylinder;
        }
    }
}
