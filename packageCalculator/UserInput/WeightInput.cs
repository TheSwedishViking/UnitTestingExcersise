using System;
using System.Collections.Generic;
using System.Text;

namespace packageCalculator.UserInput
{
    public class WeightInput
    {
        public double UserDecideWeight()
        {
            Console.WriteLine("Ange vikten på paketet i kg:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double weight))
            {
                return weight;
            }
            else
            {
                throw new ArgumentException("Invalid weight input");
            }
        }
    }
}
