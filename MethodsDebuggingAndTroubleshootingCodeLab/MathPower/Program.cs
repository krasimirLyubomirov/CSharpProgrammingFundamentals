namespace MathPower
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double MathPower = GetPower(number, power);
            Console.WriteLine(MathPower);
        }

        static double GetPower(double number, double power)
        {
            double results = Math.Pow(number, power);
            return results;
        }
    }
}
