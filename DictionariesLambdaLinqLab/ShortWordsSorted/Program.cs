namespace ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(new char[] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'}, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            IEnumerable<string> words = input.OrderBy(x => x).Distinct().Where(x=> x.Length < 5);

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
