namespace CubeProperties
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine("{0:f2}", GetFaceDiagonals(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:f2}", GetSpaceDiagonals(side));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine("{0:f2}", GetVolume(side));
            }
            else if (parameter == "area")
            {
                Console.WriteLine("{0:f2}", GetArea(side));
            }
        }
        
        static double GetFaceDiagonals (double side)
        {
            double face = Math.Sqrt(2 * Math.Pow(side, 2));
            return face;
        }

        static double GetSpaceDiagonals (double side)
        {
            double space = Math.Sqrt(3 * Math.Pow(side, 2));
            return space;
        }

        static double GetVolume (double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double GetArea (double side)
        {
            double space = 6 * Math.Pow(side, 2);
            return space;
        }
    }
}
