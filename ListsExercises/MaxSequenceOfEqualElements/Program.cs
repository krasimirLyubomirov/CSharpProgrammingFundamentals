namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCounter = 0;
            int maxNumber = 0;

            foreach (int num1 in numbers)
            {
                int counter = 0;

                foreach (int num2 in numbers)
                {
                    if (num1 == num2)
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = num1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumber} ");
            }

            Console.WriteLine();
        }
    }
}
