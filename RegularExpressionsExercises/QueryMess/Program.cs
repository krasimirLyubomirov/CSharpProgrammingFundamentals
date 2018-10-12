namespace QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<key>[^\=&\?]+)=(?<value>[^\=&\?]+)");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break; 
                }

                MatchCollection matches = regex.Matches(line);
                Dictionary<string, List<string>> keys = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();

                    if (keys.ContainsKey(key) == false)
                    {
                        keys.Add(key, new List<string>());
                    }

                    keys[key].Add(value);
                }

                foreach (var pair in keys)
                {
                    Console.Write($"{pair.Key}=[{String.Join(", ", pair.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
