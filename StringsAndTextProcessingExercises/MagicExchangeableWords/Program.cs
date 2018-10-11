namespace MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();

            HashSet<char> firstWord = new HashSet<char>(inputArray[0]);
            HashSet<char> secondWord = new HashSet<char>(inputArray[1]);

            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }
    }
}
