namespace Hideout
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine()
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();

                string hideout = Regex.Escape(clues[0]);
                int minSize = int.Parse(clues[1]);

                string pattern = $@"[{hideout}]+";

                foreach (Match item in Regex.Matches(map, pattern))
                {
                    if (item.Length >= minSize)
                    {
                        Console.WriteLine($"Hideout found at index {item.Index} and it is with size {item.Length}!");
                        return;
                    }
                }
            }
        }
    }
}
