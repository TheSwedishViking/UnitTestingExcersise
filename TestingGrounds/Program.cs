namespace TestingGrounds
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<int, string> people = new Dictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                people.Add(i, $"Person {i + 1}");
            }

            foreach (var kvp in people)
            {
                Console.WriteLine("Key Id: " + kvp.Key + ", Value: " + kvp.Value);
            }
            Console.ReadLine();
        }
    }
}
