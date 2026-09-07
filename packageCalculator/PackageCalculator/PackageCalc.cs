using packageCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace packageCalculator.PackageCalculator
{
    public class PackageCalc
    {
        public double CalculatePrice(Shape shape)
        {
            return shape.Price;
        }
    }
}
