namespace FoldAndSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = array.Length / 4;

            int[] left = GetPart(array, k, 0);
            int[] middle = GetPart(array, 2 * k, k);
            int[] right = GetPart(array, k, 3 * k);

            Array.Reverse(left);
            Array.Reverse(right);

            int[] merged = new int[2 * k];
            int index = 0;

            for (int i = 0; i < k; i++)
            {
                merged[index++] = left[i];
            }

            for (int i = 0; i < k; i++)
            {
                merged[index++] = right[i];
            }

            for (int i = 0; i < middle.Length; i++)
            {
                int sum = middle[i] + merged[i];
                Console.Write($"{sum} ");
            }

            Console.WriteLine();
        }

        static int[] GetPart(int[] array, int size, int startIndex)
        {
            int[] part = new int[size];
            for (int i = startIndex; i < size + startIndex; i++)
            {
                part[i - startIndex] = array[i];
            }

            return part;
        }
    }
}
