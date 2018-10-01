namespace MasterNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool isDivisible = IsDivisible(i);
                bool hasEvenDigit = HasEvenDigit(i);

                bool isMaster = isPalindrome && isDivisible && hasEvenDigit;

                if (isMaster)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasEvenDigit(long number)
        {
            bool hasEvenDigit = false;

            while (number > 0)
            {
                long digit = number % 10;
                if (digit % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }
                number /= 10;
            }

            return hasEvenDigit;
        }

        static bool IsDivisible(long number)
        {
            long sum = 0;

            while (number > 0)
            {
                long digit = number % 10;
                sum += digit;
                number /= 10;
            }

            bool isDivisible = sum % 7 == 0;
            return isDivisible;
        }

        static bool IsPalindrome(long number)
        {
            string reversed = "";
            string numAsString = number.ToString();

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                reversed += numAsString[i];
            }

            long reversedNumber = long.Parse(reversed);

            bool isPalindrome = numAsString == reversed;
            return isPalindrome;
        }
    }
}
