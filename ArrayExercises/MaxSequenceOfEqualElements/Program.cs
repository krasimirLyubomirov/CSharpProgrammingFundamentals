namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCount = 1;
            int count = 1;
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i - 1 >= 0 && array[i] == array[i - 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        position = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = position; i < position + maxCount; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
