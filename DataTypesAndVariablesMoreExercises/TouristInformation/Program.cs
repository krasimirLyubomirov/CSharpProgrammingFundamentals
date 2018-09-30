namespace TouristInformation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());

            if (imperialUnit == "miles")
            {
                decimal kilometers = value * 1.6m;
                Console.WriteLine($"{value} miles = {kilometers:f2} kilometers");
            }
            else if (imperialUnit == "inches")
            {
                decimal centimeters = value * 2.54m;
                Console.WriteLine($"{value} inches = {centimeters:f2} centimeters");
            }
            else if (imperialUnit == "feet")
            {
                decimal centimeters = value * 30m;
                Console.WriteLine($"{value} feet = {centimeters:f2} centimeters");
            }
            else if (imperialUnit == "yards")
            {
                decimal meters = value * 0.91m;
                Console.WriteLine($"{value} yards = {meters:f2} meters");
            }
            else if (imperialUnit == "gallons")
            {
                decimal liters = value * 3.8m;
                Console.WriteLine($"{value} gallons = {liters:f2} liters");
            }
        }
    }
}
