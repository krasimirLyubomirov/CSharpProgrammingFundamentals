namespace TripleSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        bool sums = input[i] + input[j] == input[k];
                        if (sums)
                        {
                            Console.WriteLine($"{input[i]} + {input[j]} == {input[k]}");
                            isFound = true;
                            break;
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
