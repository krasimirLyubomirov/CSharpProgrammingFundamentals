namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int length = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCounter++;
                }

                if (firstArray[firstArray.Length-1-i] == secondArray[secondArray.Length-1-i])
                {
                    rightCounter++;
                }
            }

            int max = Math.Max(leftCounter, rightCounter);
            Console.WriteLine(max);
        }
    }
}
