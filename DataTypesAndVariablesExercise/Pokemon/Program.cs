namespace Pokemon
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int originPokePower = int.Parse(Console.ReadLine());
            int pokePower = originPokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetCounter = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                if (pokePower == originPokePower / 2 && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }

                targetCounter++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCounter);
        }
    }
}
