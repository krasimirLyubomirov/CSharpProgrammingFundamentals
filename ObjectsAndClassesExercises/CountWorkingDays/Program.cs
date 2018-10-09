namespace CountWorkingDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = 
            {
                new DateTime(4, 1, 1),
                new DateTime(4, 3, 3),
                new DateTime(4, 5, 1),
                new DateTime(4, 5, 6),
                new DateTime(4, 5, 24),
                new DateTime(4, 9, 6),
                new DateTime(4, 9, 22),
                new DateTime(4, 11, 1),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int counter = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                DateTime currentDay = new DateTime(4, day.Month, day.Day);

                if (holidays.Contains(currentDay) == false)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
