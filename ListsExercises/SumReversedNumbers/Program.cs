namespace SumReversedNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string sequenceOfNumbers = Console.ReadLine();
            string manipulateNumbers = string.Empty;

            foreach (var number in sequenceOfNumbers.Split())
            {
                string temp = string.Empty;
                foreach (var num in number.ToCharArray())
                {
                    temp = num + temp;
                }

                manipulateNumbers = manipulateNumbers + temp + " ";
            }

            string[] reversedNumbers = manipulateNumbers.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int[] numbers = Array.ConvertAll(reversedNumbers, int.Parse);

            int sumArray = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sumArray += numbers[i];
            }

            Console.WriteLine(sumArray);
        }
    }
}
