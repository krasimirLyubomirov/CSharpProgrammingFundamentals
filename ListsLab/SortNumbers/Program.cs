namespace SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOfNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            listOfNumbers.Sort();

            Console.WriteLine(string.Join(" <= ", listOfNumbers));
        }
    }
}
