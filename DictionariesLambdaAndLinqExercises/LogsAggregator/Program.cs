namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> data =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] logsInfo = Console.ReadLine().Split();
                string ip = logsInfo[0];
                string user = logsInfo[1];
                int duration = int.Parse(logsInfo[2]);

                if (data.ContainsKey(user) == false)
                {
                    data.Add(user, new SortedDictionary<string, int>());
                }
                if (data[user].ContainsKey(ip) == false)
                {
                    data[user].Add(ip, 0);
                }

                data[user][ip] += duration;
            }

            foreach (var outerPair in data)
            {
                int sum = outerPair.Value.Values.Sum();

                Console.Write($"{outerPair.Key}: {sum} ");
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
