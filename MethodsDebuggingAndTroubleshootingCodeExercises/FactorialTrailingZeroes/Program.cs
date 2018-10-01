namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger factorialNumber = Factorial(number);
            BigInteger factroialZeroes = CountOfZero(factorialNumber);

            Console.WriteLine(factroialZeroes);
        }

        static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        static BigInteger CountOfZero (BigInteger number)
        {
            BigInteger zeroesCounter = 0;

            while (number % 10 == 0)
            {
                zeroesCounter++;
                number /= 10;
            }

            return zeroesCounter;
        }
    }
}
