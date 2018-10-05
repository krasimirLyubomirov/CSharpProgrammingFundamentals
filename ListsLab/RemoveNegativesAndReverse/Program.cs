namespace RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            list.RemoveAll(x => x < 0);
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
