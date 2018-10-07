namespace ImmuneSystem
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());

            int startHealth = initialHealth;
            List<string> virusNames = new List<string>();
            int timeToDefeat = 0;

            bool immuneDefeated = false;

            while (true)
            {
                string virusName = Console.ReadLine();

                if (virusName == "end")
                {
                    break;
                }

                char[] letters = virusName.ToCharArray();
                int virusStrength = 0;

                for (int i = 0; i < letters.Length; i++)
                {
                    virusStrength += letters[i];
                }

                virusStrength = virusStrength / 3;
                timeToDefeat = virusStrength * letters.Length;

                for (int i = 0; i < virusNames.Count; i++)
                {
                    if (virusNames[i] == virusName)
                    {
                        timeToDefeat = timeToDefeat / 3;
                    }
                }

                virusNames.Add(virusName);
                Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");

                if (initialHealth > timeToDefeat)
                {
                    int minutes = timeToDefeat / 60;
                    int seconds = timeToDefeat % 60;

                    Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                }
                else
                {
                    immuneDefeated = true;
                    break;
                }

                initialHealth -= timeToDefeat;

                Console.WriteLine($"Remaining health: {initialHealth}");

                initialHealth = initialHealth + (initialHealth * 20 / 100);

                if (startHealth < initialHealth)
                {
                    initialHealth = startHealth;
                }
            }

            if (immuneDefeated)
            {
                Console.WriteLine("Immune System Defeated.");
            }
            else
            {
                Console.WriteLine($"Final Health: {initialHealth}");
            }
        }
    }
}
