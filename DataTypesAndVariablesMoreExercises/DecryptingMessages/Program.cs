namespace DecryptingMessages
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;
            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                word = Convert.ToString(letter);
                result += word;
            }

            Console.WriteLine($"{result}");
        }
    }
}
