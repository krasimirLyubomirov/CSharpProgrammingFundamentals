
namespace circleArea
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * r * r;
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
