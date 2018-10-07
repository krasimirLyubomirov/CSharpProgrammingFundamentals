namespace FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length / 4;

            int[] left = input.Take(k).Reverse().ToArray();
            int[] right = input.Reverse().Take(k).ToArray();
            int[] upper = left.Concat(right).ToArray();
            int[] downer = input.Skip(k).Take(2 * k).ToArray();

            IEnumerable<int> sum = upper.Select((x, index) => x + downer[index]);
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
