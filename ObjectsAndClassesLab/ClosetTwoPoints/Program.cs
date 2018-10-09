namespace ClosetTwoPoints
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closetPoints = FindClosetTwoPoints(points);

            PrintDistance(closetPoints);
            PrintPoint(closetPoints[0]);
            PrintPoint(closetPoints[1]);
        }

        static Point[] ReadPoints()
        {
            int number = int.Parse(Console.ReadLine());
            Point[] points = new Point[number];

            for (int i = 0; i < number; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] points)
        {
            double distance = calculateDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static Point[] FindClosetTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closetTwoPoints = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = calculateDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closetTwoPoints = new Point[] { points[i], points[j] };
                    }
                }
            }

            return closetTwoPoints;
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }

        static double calculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}

