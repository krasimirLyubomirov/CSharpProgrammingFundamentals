namespace OddFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            int average = (int)evenNumbers.Average();

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                if (evenNumbers[i] > average)
                {
                    evenNumbers[i]++;
                }
                else if (evenNumbers[i] <= average)
                {
                    evenNumbers[i]--;
                }
            }

            Console.WriteLine(String.Join(" ", evenNumbers));
        }
    }
}
