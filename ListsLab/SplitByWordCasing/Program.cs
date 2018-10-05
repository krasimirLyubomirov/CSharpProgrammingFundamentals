namespace SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> mixed = new List<string>();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string current = input[i];
                
                if(IsLower(current))
                {
                    lower.Add(current);
                }
                else if (IsUpper(current))
                {
                    upper.Add(current);
                }
                else
                {
                    mixed.Add(current);
                }
            }

            Console.WriteLine("Lower-case: " + String.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + String.Join(", ", upper));
        }

        static bool IsLower(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || 'z' < symbol)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsUpper(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || 'Z' < symbol)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
