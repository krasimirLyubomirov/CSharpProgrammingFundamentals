namespace RectanglePosition
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstCoord = ReadRectangle();
            Rectangle secondCoord = ReadRectangle();

            Console.WriteLine(firstCoord.IsInside(secondCoord) ? "Inside" : "Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            int[] pointCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new Rectangle(pointCoord[0], pointCoord[1], pointCoord[2], pointCoord[3]);
        }
    }
}
