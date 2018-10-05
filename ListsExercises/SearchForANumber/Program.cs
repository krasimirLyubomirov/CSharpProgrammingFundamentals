namespace SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int takeNumber = arrayOfNumbers[0];
            int deleteNumber = arrayOfNumbers[1];
            int searchNumber = arrayOfNumbers[2];

            int[] newArrayNumbers = new int[takeNumber];

            for (int i = 0; i < newArrayNumbers.Length; i++)
            {
                newArrayNumbers[i] = listOfIntegers[i];
            }

            List<int> numbers = new List<int>(newArrayNumbers);
            numbers.RemoveRange(0, deleteNumber);

            bool foundNumber = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    Console.WriteLine("YES!");
                    foundNumber = true;
                    break;
                }
            }

            if(foundNumber == false)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
