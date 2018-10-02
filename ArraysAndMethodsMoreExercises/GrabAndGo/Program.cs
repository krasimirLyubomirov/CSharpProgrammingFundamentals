namespace GrabAndGo
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long searchNumber = long.Parse(Console.ReadLine());

            long count = -1;
            long sum = 0;

            for (long i = 0; i < array.Length; i++)
            {
                if (array[i] == searchNumber)
                {
                    count = i;
                }
            }

            if (count == -1)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
