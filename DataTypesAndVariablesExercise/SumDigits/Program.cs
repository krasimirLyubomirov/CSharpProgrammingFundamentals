namespace SumDigits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            int sumOfDigit = 0;

            for (int digit = 0; digit < digits.Length; digit++)
            {
                sumOfDigit += int.Parse(digits[digit].ToString());
            }

            Console.WriteLine(sumOfDigit);
        }
    }
}
