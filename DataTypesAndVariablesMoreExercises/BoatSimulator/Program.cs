namespace BoatSimulator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            int firstTiles = 0;
            int secondTiles = 0;

            for (int i = 1; i <= num; i++)
            {
                string wordMoves = Console.ReadLine();

                if (firstTiles >= 50 || secondTiles >= 50)
                {
                    break;
                }
                else
                {
                    if (wordMoves == "UPGRADE")
                    {
                        firstBoat += (char)3;
                        secondBoat += (char)3;
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            secondTiles += wordMoves.Length;
                        }
                        else
                        {
                            firstTiles += wordMoves.Length;
                        }
                    }
                }
            }

            if (firstTiles > secondTiles)
            {
                Console.WriteLine($"{firstBoat}");
            }
            else if (secondBoat > firstTiles)
            {
                Console.WriteLine($"{secondBoat}");
            }
        }
    }
}
