namespace LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] longestSequence = FindLongestIncreasingSubsequence(sequence);
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length];
            int[] previous = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                previous[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        previous[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> longestSequence = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(sequence[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestSequence.Reverse();
            return longestSequence.ToArray();
        }
    }
}
