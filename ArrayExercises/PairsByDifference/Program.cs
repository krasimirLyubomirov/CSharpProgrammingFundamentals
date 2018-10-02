namespace PairsByDifference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int found = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = elements.Length - 1; j > i; j--)
                {
                    if (elements[i] - elements[j] == number || elements[j] - elements[i] == number)
                    {
                        found++;
                    }
                }
            }

            Console.WriteLine(found);
        }
    }
}
