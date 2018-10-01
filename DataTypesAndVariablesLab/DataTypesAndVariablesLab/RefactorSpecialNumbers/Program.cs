namespace RefactorSpecialNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i < 10)
                {
                    if (i == 5 || i == 7)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
                else
                {
                    double lastDigit = i % 10;
                    double sum = i / 10;

                    if (sum + lastDigit == 5 || sum + lastDigit == 7 || sum + lastDigit == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
            }
        }
    }
}
