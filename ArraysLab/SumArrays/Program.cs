namespace SumArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] biggerArray = new int[Math.Max(arrOne.Length, arrTwo.Length)];
            int sum = Math.Max(arrOne.Length, arrTwo.Length);

            for (int i = 0; i <= biggerArray.Length; i++)
            {
                sum = (arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length]);
                if (i >= biggerArray.Length)
                {
                    break;
                }

                Console.Write(sum + " ");
            }

            Console.WriteLine();
        }
    }
}
