namespace ExtractMiddleElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split().Select(int.Parse) .ToArray();
            int middleIndex = arrayOfInts.Length / 2;

            if (arrayOfInts.Length == 1)
            {
                Console.WriteLine($"{arrayOfInts[0]}");
            }
            else if (arrayOfInts.Length % 2 == 1)
            {
                Console.WriteLine($"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}\n{arrayOfInts[middleIndex + 1]}");
            }
            else
            {
                Console.WriteLine($"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}");
            }
        }
    }
}
