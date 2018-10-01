namespace TemperatureConversion
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double farenheint = double.Parse(Console.ReadLine());

            double celsiusDegrees = FarenheintToCelsius(farenheint);
            Console.WriteLine("{0:f2}", celsiusDegrees);
        }

        static double FarenheintToCelsius(double num)
        {
            return (num - 32) * 5 / 9;
        }
    }
}
