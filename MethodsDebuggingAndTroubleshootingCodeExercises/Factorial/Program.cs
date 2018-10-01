namespace Factorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger factorialNumber = Factorial(number);
            Console.WriteLine(factorialNumber);
        }

        static BigInteger Factorial (BigInteger number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
