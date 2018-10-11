namespace Palindrome
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
