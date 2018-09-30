namespace WaterOverflow
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int waterTank = 255;
            int sumLiters = 0;
            int liters = 0;

            for (int i = 1; i <= n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                sumLiters += liters;

                if (sumLiters > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumLiters -= liters;
                }
            }

            Console.WriteLine(sumLiters);
        }
    }
}
