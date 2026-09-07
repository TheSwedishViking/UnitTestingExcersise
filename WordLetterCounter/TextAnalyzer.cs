namespace WordLetterCounter
{
    public class TextAnalyzer
    {


        public int CountWords(string text)
        {
            string[] subs = text.Split(' ');


            int count = subs.Count();
            return count;
        }

        public int CountLetters(string text)
        {
            string str = string.Join("", text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));


            return str.Length;

        }




    }
}
