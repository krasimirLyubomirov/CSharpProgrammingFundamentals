namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> allData = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();
            Dictionary<string, double[]> averageData = new Dictionary<string, double[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = inputLine[0];
                string dragon = inputLine[1];
                int damage = GetStat(inputLine, 45, 2);
                int health = GetStat(inputLine, 250, 3);
                int armor = GetStat(inputLine, 10, 4);

                if (allData.ContainsKey(type) == false)
                {
                    allData[type] = new SortedDictionary<string, Dictionary<string, int>>();
                    averageData[type] = new double[] { 0.0, 0.0, 0.0 };
                }
                if (allData[type].ContainsKey(dragon) == false)
                {
                    allData[type][dragon] = new Dictionary<string, int>()
                    {
                        { "damage", damage }, { "health", health }, { "armor", armor }
                    };
                }
                else
                {
                    allData[type][dragon]["damage"] = damage;
                    allData[type][dragon]["health"] = health;
                    allData[type][dragon]["armor"] = armor;
                }
            }
            foreach (var type in allData)
            {
                double totalDamage = 0.0;
                double totalHealth = 0.0;
                double totalArmor = 0.0;

                foreach (var dragon in type.Value)
                {
                    totalDamage += dragon.Value["damage"];
                    totalHealth += dragon.Value["health"];
                    totalArmor += dragon.Value["armor"];
                }

                averageData[type.Key][0] = totalDamage / type.Value.Count;
                averageData[type.Key][1] = totalHealth / type.Value.Count;
                averageData[type.Key][2] = totalArmor / type.Value.Count;
            }
            foreach (var type in allData)
            {
                Console.WriteLine($"{type.Key}::({averageData[type.Key][0]:f2}/{averageData[type.Key][1]:f2}/{averageData[type.Key][2]:f2})");
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value["damage"]}, health: {dragon.Value["health"]}, armor: {dragon.Value["armor"]}");
                }
            }
        }

        private static int GetStat(string[] inputLine, int defaultValue, int index)
        {
            int stat = 0;
            try
            {
                stat = int.Parse(inputLine[index]);
            }
            catch (Exception)
            {
                stat = defaultValue;
            }

            return stat;
        }
    }
}
