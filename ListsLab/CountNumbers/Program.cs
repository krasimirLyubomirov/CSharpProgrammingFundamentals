namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Sort();

            int count = 1;
            int current = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (current == numbers[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{current} -> {count}");
                    count = 1;
                    current = numbers[i];
                }
            }

            Console.WriteLine($"{current} -> {count}");
        }
    }
}
