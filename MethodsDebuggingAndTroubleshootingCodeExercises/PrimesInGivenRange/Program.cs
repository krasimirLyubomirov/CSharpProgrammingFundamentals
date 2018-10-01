namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            FindPrimesInRange(first, second);
        }

        static void FindPrimesInRange(long firstNum, long secondNum)
        {
            if (firstNum < 2)
            {
                firstNum = 2;
            }

            bool firstPrime = true;
            for (long i = firstNum; i <= secondNum; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime == true && firstPrime == true)
                {
                    Console.Write(i);
                    firstPrime = false;
                }
                else if (prime)
                {
                    Console.Write(", ");
                    Console.Write(i);
                }
            }

            Console.WriteLine();
        }
    }
}
