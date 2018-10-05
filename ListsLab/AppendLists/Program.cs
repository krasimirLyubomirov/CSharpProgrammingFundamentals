namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<string> results = new List<string>();
            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {
                string text = input[i];
                string[] splitted = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string merged = string.Join(" ", splitted);
                results.Add(merged);
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
