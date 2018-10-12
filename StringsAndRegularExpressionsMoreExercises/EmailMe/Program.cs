namespace EmailMe
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@');

            string first = email[0];
            string second = email[1];

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < first.Length; i++)
            {
                firstSum += first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                secondSum += second[i];
            }

            if (firstSum >= secondSum)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
