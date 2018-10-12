namespace MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(-?)\d+(\.\d+)?($|(?=\s))";
            MatchCollection matches = Regex.Matches(text, pattern);
            
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
