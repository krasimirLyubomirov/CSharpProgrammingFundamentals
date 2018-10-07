namespace SortTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> datetime = Console.ReadLine().Split().OrderBy(x=> x).ToList();
            Console.WriteLine(String.Join(", ", datetime));
        }
    }
}
