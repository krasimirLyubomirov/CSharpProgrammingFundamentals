namespace LargestThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            IEnumerable<int> numbers = input.OrderByDescending(x => x).Take(3);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
