namespace CenterPoint
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosetPoint(x1, y1, x2, y2);
        }

        static void ClosetPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double second = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first < second)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
