namespace WeatherForecast
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            float isFloat;
            sbyte isSbyte;
            byte isByte;
            int isInt;
            long isLong;

            
            if (sbyte.TryParse(num, out isSbyte))
            {
                Console.WriteLine("Sunny");
            }
            else if (byte.TryParse(num, out isByte))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(num, out isInt))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(num, out isLong))
            {
                Console.WriteLine("Windy");
            }
            else if (float.TryParse(num, out isFloat))
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
