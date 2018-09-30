namespace BeerKegs
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());

            double volume = 0;
            double totalVolume = 0;
            string totalModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.Pow(radius, 2) * Math.PI * height;

                if (volume > totalVolume)
                {
                    totalVolume = volume;
                    totalModel = model;
                }
            }

            Console.WriteLine($"{totalModel}");
        }
    }
}
