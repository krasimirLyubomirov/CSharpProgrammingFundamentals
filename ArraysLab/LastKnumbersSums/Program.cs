namespace LastKnumbersSums
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] sequences = new long[n];
            sequences[0] = 1;

            for (int i = 1; i < sequences.Length; i++)
            {
                long startIndex = Math.Max(0, i - k);
                long endIndex = i - 1;
                long sum = 0;

                for (long j = startIndex; j <= endIndex; j++)
                {
                    sum += sequences[j];
                }

                sequences[i] = sum;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(sequences[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
