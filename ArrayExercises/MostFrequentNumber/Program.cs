namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxNumber = 0;
            int maxCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = array[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
