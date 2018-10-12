namespace KarateStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<char> peshoTraining = Console.ReadLine().ToCharArray().ToList();
            int punchStrength = 0;

            for (int i = 0; i < peshoTraining.Count; i++)
            {
                if (peshoTraining[i] == '>')
                {
                    punchStrength += int.Parse(peshoTraining[i + 1].ToString());
                }
                else
                {
                    if (punchStrength > 0)
                    {
                        peshoTraining.RemoveAt(i);
                        i--;
                        punchStrength--;
                    }
                }
            }

            Console.WriteLine(String.Join("", peshoTraining));
        }
    }
}
