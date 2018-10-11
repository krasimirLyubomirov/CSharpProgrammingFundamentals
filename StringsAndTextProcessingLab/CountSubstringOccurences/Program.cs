namespace CountSubstringOccurences
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = input.IndexOf(pattern);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
