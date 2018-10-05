namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombNumbers[0];
            int range = bombNumbers[1];
            int bombIndex = numbers.IndexOf(bombNumber);

            while (bombIndex != - 1)
            {
                int leftIndex = bombIndex - range;
                int rightIndex = bombIndex + range;

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                if (rightIndex > numbers.Count - 1)
                {
                    rightIndex = numbers.Count - 1;
                }

                int count = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, count);

                bombIndex = numbers.IndexOf(bombNumber);
            }

            int sum = 0;
            foreach (int nums in numbers)
            {
                sum += nums;
            }

            Console.WriteLine(sum);
        }
    }
}
