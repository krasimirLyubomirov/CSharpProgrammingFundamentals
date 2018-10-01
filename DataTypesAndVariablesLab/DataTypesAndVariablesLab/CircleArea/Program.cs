namespace CircleArea
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
