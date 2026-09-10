using System.Text.RegularExpressions;

namespace TDDprogram
{
    public class IsbnCalculator
    {






        public bool VerifyIsbnFormat(string number)
        {
            Regex isbnPattern = new Regex("(^[0-9]{10}$)|(^[0-9]{13}$)");
            return isbnPattern.IsMatch(number) ? true : false;
        }

        public bool VerifyPersonalNumberFormat(string number)
        {
            Regex isbnPattern = new Regex("(^[0-9]{10}$)|(^[0-9]{12}$)");
            return isbnPattern.IsMatch(number) ? true : false;
        }


    }



}
