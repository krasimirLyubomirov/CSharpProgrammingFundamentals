namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b(\d{2})([.\/-])([A-Z][a-z]{2})\2(\d{4})\b");
            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                string day = item.Groups[1].Value;
                string month = item.Groups[3].Value;
                string year = item.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
