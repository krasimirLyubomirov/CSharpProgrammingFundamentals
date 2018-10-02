namespace RotateAndSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int times = int.Parse(Console.ReadLine());

            int[] rotate = new int[integerArray.Length];
            int[] sum = new int[integerArray.Length];

            for (int i = 0; i < times; i++)
            {
                for (int j = 1; j < integerArray.Length; j++)
                {
                    rotate[j] = integerArray[j - 1];
                }
                rotate[0] = integerArray[integerArray.Length - 1];

                for (int k = 0; k < integerArray.Length; k++)
                {
                    sum[k] += rotate[k];
                }

                rotate.CopyTo(integerArray, 0);
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
