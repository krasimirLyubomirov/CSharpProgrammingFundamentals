namespace Heists
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long[] elements = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long totalEarnings = 0;
            long totalExpenses = 0;
            long expenses = 0;

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "Jail" && commands[1] == "Time")
                {
                    break;
                }

                if (long.TryParse(commands[1], out expenses))
                {
                    totalExpenses += expenses;
                }

                if (commands[0] != "Jail" && commands[1] != "Time")
                {
                    char[] symbols = commands[0].ToCharArray();

                    for (int i = 0; i < symbols.Length; i++)
                    {
                        if (symbols[i] == '%')
                        {
                            totalEarnings += elements[0];
                        }
                        else if (symbols[i] == '$')
                        {
                            totalEarnings += elements[1];
                        }
                    }
                }
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}
