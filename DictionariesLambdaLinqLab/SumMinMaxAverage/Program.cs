namespace SumMinMaxAverage
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            int number = 0;
            int[] numbers = new int [times];

            for (int i = 0; i < times; i++)
            {
                number = int.Parse(Console.ReadLine());
                numbers[i] += number;
            }

            Console.WriteLine("Sum = " + String.Join("", numbers.Sum()));
            Console.WriteLine("Min = " + String.Join("", numbers.Min()));
            Console.WriteLine("Max = " + String.Join("", numbers.Max()));
            Console.WriteLine("Average = " + String.Join("", numbers.Average()));
        }
    }
}
