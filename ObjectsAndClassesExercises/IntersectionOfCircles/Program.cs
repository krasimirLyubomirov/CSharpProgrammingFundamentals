namespace IntersectionOfCircles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle(Console.ReadLine());
            Circle circle2 = ReadCircle(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(circle2.Point.X - circle1.Point.X, 2) + 
                                       (Math.Pow(circle2.Point.Y - circle1.Point.Y, 2)));
            double sumRadius = circle1.Radius + circle2.Radius;
            bool intersect = distance <= sumRadius;

            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static Circle ReadCircle(string input)
        {
            double[] tokens = input.Split().Select(double.Parse).ToArray();

            double x = tokens[0];
            double y = tokens[1];
            double radius = tokens[2];

            Point point = new Point(x, y);
            Circle circle = new Circle(point, radius);

            return circle;
        }
    }
}
