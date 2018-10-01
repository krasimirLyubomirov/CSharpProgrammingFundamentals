namespace GeometryCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = GetTriangleArea(side, height);
                Console.WriteLine("{0:f2}", area);
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = GetSquareArea(side);
                Console.WriteLine("{0:f2}", area);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = GetRectangleArea(width, height);
                Console.WriteLine("{0:f2}", area);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = GetCircleArea(radius);
                Console.WriteLine("{0:f2}", area);
            }
        }

        static double GetTriangleArea (double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        static double GetSquareArea (double side)
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        static double GetRectangleArea (double width, double height)
        {
            double area = width * height;
            return area;
        }
        
        static double GetCircleArea (double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
