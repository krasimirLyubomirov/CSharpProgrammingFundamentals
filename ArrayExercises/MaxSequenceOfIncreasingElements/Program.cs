namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long[] items = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long length = 1;
            long start = 0;
            long bestStart = 0;
            long bestLength = 1;
            long helper = 1;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= items[helper])
                {
                    length++;
                    helper++;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 1;
                    start = i;
                    helper = i;
                }
            }
            for (long j = bestStart; j < bestStart + bestLength; j++)
            {
                Console.Write(items[j] + " ");
            }

            Console.WriteLine();
        }
    }
}
