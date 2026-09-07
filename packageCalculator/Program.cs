namespace packageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Oscar!");


            Console.WriteLine("skriv vikt");

            var weight = Console.ReadLine();

            if (double.TryParse(weight, out double packageWeight))
            {
                Console.WriteLine("skriv dimension");


            }

        }
    }
}
