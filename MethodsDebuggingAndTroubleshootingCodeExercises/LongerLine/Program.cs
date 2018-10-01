namespace LongerLine
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            CenterLine(x1, y1, x2, y2, x3, y3, x4, y4);
            if (LineLenght(x1, y1, x2, y2) == LineLenght(x3, y3, x4, y4))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static void CenterLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double diagonalOne = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double diagonalTwo = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double diagonalThree = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double diagonalFour = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if ((diagonalOne + diagonalTwo) > (diagonalThree + diagonalFour))
            {
                if (diagonalOne > diagonalTwo)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }

            if ((diagonalThree + diagonalFour) > (diagonalOne + diagonalTwo))
            {
                if (diagonalThree > diagonalFour)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }

        static double LineLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
