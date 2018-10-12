namespace ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            string pattern = $@"\b{searchWord}\b";
            Regex regex = new Regex(pattern);
            string[] words = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Select(e => e.Trim()).ToArray();

            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
