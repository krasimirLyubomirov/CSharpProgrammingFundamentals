namespace PrimeChecker
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool results = IsPrime(n);
            Console.WriteLine(results);
        }

        static bool IsPrime(long number)
        {
            if (number == 0 || number == 1) 
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
