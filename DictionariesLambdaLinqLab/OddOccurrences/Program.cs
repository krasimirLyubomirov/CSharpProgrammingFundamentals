namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
            }

            List<string> results = new List<string>();

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    results.Add(word.Key);
                }
            }

            Console.WriteLine(String.Join(", ", results));
        }
    }
}
