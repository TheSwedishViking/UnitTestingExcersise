using packageCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace packageCalculator.UserInput
{
    public class PackageInput
    {
        public Shape UserDecideShape()
        {
            Console.WriteLine("Goddagens! Rätblock eller Cylinder?!");
            Console.WriteLine("1. Rätblock");
            Console.WriteLine("2. Cylinder");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    return new CubicPackage();
                case "2":
                    return new Cylinder();
                default:
                    throw new ArgumentException("Invalid shape selection");
            }
        }
    }
}
