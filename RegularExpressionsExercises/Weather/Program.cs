namespace Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<double, string>> cities = new Dictionary<string, 
                KeyValuePair<double, string>>();
            Regex regex = new Regex(@"(?<code>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-Za-z]+)\|");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (match.Success == false)
                {
                    continue;
                }

                string city = match.Groups["code"].Value;
                double temp = double.Parse(match.Groups["temp"].Value);
                string type = match.Groups["type"].Value;

                if (cities.ContainsKey(city) == false)
                {
                    cities.Add(city, new KeyValuePair<double, string>(temp, type));
                }
                else
                {
                    cities[city] = new KeyValuePair<double, string>(temp, type);
                }
            }

            foreach (var city in cities.OrderBy(c => c.Value.Key))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Key:f2} => {city.Value.Value}");
            }
        }
    }
}
