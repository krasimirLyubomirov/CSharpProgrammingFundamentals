namespace MakeaWord
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string finalWord = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                string word = Convert.ToString(letter);
                finalWord += word;
            }

            Console.WriteLine($"The word is: {finalWord}");
        }
    }
}
