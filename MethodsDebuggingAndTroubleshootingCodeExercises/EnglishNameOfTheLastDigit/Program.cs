namespace EnglishNameOfTheLastDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            string lastDigitName = GetLastDigit(Math.Abs(number));
            Console.WriteLine(lastDigitName);
        }

        static string GetLastDigit(long number)
        {
            long last = number % 10;

            string lastDigitNumber = "";

            if (last == 0)
            {
                lastDigitNumber = "zero";
            }
            else if (last == 1)
            {
                lastDigitNumber = "one";
            }
            else if (last == 2)
            {
                lastDigitNumber = "two";
            }
            else if (last == 3)
            {
                lastDigitNumber = "three";
            }
            else if (last == 4)
            {
                lastDigitNumber = "four";
            }
            else if (last == 5)
            {
                lastDigitNumber = "five";
            }
            else if (last == 6)
            {
                lastDigitNumber = "six";
            }
            else if (last == 7)
            {
                lastDigitNumber = "seven";
            }
            else if (last == 8)
            {
                lastDigitNumber = "eight";
            }
            else if (last == 9)
            {
                lastDigitNumber = "nine";
            }

            return lastDigitNumber;
        }
    }
}
