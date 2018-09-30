namespace StringConcatenation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string nothing = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if (type == "even")
                {
                    if (i % 2 == 0)
                    {
                        nothing += word + $"{symbol}";
                    }
                }
                else if (type == "odd")
                {
                    if (i % 2 != 0)
                    {
                        nothing += word + $"{symbol}";
                    }
                }
            }

            string result = nothing.Remove(nothing.Length - 1);
            Console.WriteLine($"{result}");
        }
    }
}
