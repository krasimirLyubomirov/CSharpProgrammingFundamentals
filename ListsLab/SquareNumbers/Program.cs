namespace SquareNumbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squares = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];

                double square = Math.Sqrt(current);
                int whole = (int)square;

                if (square == whole)
                {
                    squares.Add(current);
                }
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
