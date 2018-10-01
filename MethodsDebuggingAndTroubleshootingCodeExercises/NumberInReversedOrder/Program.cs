namespace NumberInReversedOrder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string reversed = ReverseInput(number);
            Console.WriteLine(reversed);
        }

        static string ReverseInput(string number)
        {
            string reversed = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }

            return reversed;
        }
    }
}
