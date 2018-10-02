namespace JumpAround
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumOfNumbers = 0;
            int index = 0;
            int maxIndex = numbers.Count - 1;

            while (true)
            {
                sumOfNumbers += numbers[index];

                int nextIndex = index + numbers[index];

                if (nextIndex <= maxIndex)
                {
                    index = nextIndex;
                    continue;
                }

                nextIndex = index - numbers[index];

                if (nextIndex >= 0)
                {
                    index = nextIndex;
                    continue;
                }

                break;
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
