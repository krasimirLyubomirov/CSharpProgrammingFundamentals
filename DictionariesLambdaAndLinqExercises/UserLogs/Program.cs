namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> site = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                string[] ipInput = input[0].Split('=').ToArray();
                string ip = ipInput[1];
                string[] userInput = input[2].Split('=').ToArray();
                string user = userInput[1];

                if (site.ContainsKey(user) == false)
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    site.Add(user, current);
                }
                else
                {
                    if (site[user].ContainsKey(ip) == false)
                    {
                        site[user].Add(ip, 1);
                    }
                    else
                    {
                        site[user][ip]++;
                    }
                }
            }

            foreach (var user in site)
            {
                Console.WriteLine($"{user.Key}: ");
                List<string> dotEnd = new List<string>();

                foreach (var ip in user.Value)
                {
                    dotEnd.Add($"{ip.Key} => {ip.Value}");
                }

                Console.WriteLine(String.Join(", ", dotEnd) + ".");
            }
        }
    }
}
