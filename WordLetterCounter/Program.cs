namespace WordLetterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ord = "För västkustens tjejer é det bästa som finns";

            TextAnalyzer textAnalyzer = new TextAnalyzer();

            int antaletWords = textAnalyzer.CountWords(ord);

            int antaletBokstäver = textAnalyzer.CountLetters(ord);

            Console.WriteLine(ord);

            Console.WriteLine(antaletBokstäver);
            Console.WriteLine(antaletWords);
        }
    }
}
