namespace CatchTheThief
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string numericalType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long number;
            long isNumber = long.MinValue;

            for (int i = 1; i <= n; i++)
            {
                number = long.Parse(Console.ReadLine());

                if (numericalType == "sbyte")
                {
                    if (sbyte.MinValue <= number && number <= sbyte.MaxValue)
                    {
                        if (number > isNumber)
                        {
                            isNumber = number;
                        }
                    }
                }
                else if (numericalType == "int")
                {
                    if (int.MinValue <= number && number <= int.MaxValue)
                    {
                        if (number > isNumber)
                        {
                            isNumber = number;
                        }
                    }
                }
                else if (numericalType == "long")
                {
                    if (long.MinValue <= number && number <= long.MaxValue)
                    {
                        if (number > isNumber)
                        {
                            isNumber = number;
                        }
                    }
                }
            }

            double years = 0;
            double totalYears = 0;  

            if (isNumber > 0)
            {
                years = Math.Abs(isNumber / 127.0);
                totalYears = Math.Ceiling(years);

            }
            else
            {
                years = Math.Abs(isNumber / -128.0);
                totalYears = Math.Ceiling(years);
            }

            if (years > 1)
            {
                Console.WriteLine($"Prisoner with id {isNumber} is sentenced to {totalYears} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {isNumber} is sentenced to {totalYears} year");
            }
        }
    }
}
