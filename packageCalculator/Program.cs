using packageCalculator.UserInput;

namespace packageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double postageCostPerKm = 2;
            int distanceCustommer = 0;
            double totalPrice = 0;

            List<Models.Shape> packages = new();
            bool userPackageComplete = false;

            while (!userPackageComplete)
            {
                if (packages.Count > 0)
                {
                    Console.WriteLine(packages.Count);
                }
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

                Console.WriteLine("pris på denna produkt " + shape.Price);
                packages.Add(shape);

                bool userDone = false;
                int userInputNumber = 0;

                Console.WriteLine("1: Färdig?    2: Nej");
                Console.WriteLine("Nuvarande rabatt ! : " + (100 - packages.Count)
                    * 0.01 + " %");

                while (!userDone)
                {
                    if (int.TryParse(Console.ReadLine(), out userInputNumber))
                    {
                        userDone = true;
                    }
                    else { Console.WriteLine("Heltal!"); }
                }
                switch (userInputNumber)
                {
                    case 1:
                        userPackageComplete = true;
                        break;

                    case 2:

                        break;
                }

            }



            Console.WriteLine("Nästan färdig! Hur långt bort bor du ifrån våran terminal? " +
                "svara i hela kilometer :)");

            bool boolNumber = true;
            while (boolNumber)
            {
                if (int.TryParse(Console.ReadLine(), out distanceCustommer))
                {
                    boolNumber = false;
                }
                else { Console.WriteLine("Heltal!"); }
            }



            double discount = (100 - packages.Count) * 0.01;

            totalPrice += (packages.Sum(p => p.Price)) * discount;


            Console.WriteLine("Och priset är....");
            Console.WriteLine($"Pris: {totalPrice + (postageCostPerKm * distanceCustommer)} kr");
            Console.WriteLine("Varav fraktkostnad : " + postageCostPerKm * distanceCustommer + " kr");




        }
    }
}
