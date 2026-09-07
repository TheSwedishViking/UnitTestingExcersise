using packageCalculator.UserInput;

namespace packageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                var pkgIn = new PackageInput();
                var weightInput = new WeightInput();
                var dimensionINput = new DimensionInput();

                var shape = pkgIn.UserDecideShape();
                Console.WriteLine("Du valde: " + shape.GetType().Name);

                shape.Weight = weightInput.UserDecideWeight();
                Console.WriteLine("Registerard vikt: " + shape.Weight);

                shape = dimensionINput.InputDimesion(shape);
                Console.WriteLine("Måtten är (som nedan);");
                Console.WriteLine(shape.DimensionsPrinted);

                Console.WriteLine("Och priset är....");
                Console.WriteLine($"Pris: {shape.Price} kr");

            }


        }
    }
}
