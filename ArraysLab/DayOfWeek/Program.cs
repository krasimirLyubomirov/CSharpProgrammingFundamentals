namespace DayOfWeek
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] daysInEnglish = new string[] 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysInEnglish[day - 1]);
            }
        }
    }
}
