namespace TownInfo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string popuplation = Console.ReadLine();
            string area = Console.ReadLine();

            Console.WriteLine($"Town {town} has population of {popuplation} and area {area} square km.");
        }
    }
}
