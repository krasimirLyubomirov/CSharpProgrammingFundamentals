namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Array.Reverse(input);
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
