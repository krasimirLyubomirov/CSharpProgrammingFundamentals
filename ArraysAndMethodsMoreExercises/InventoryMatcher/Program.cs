namespace InventoryMatcher
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "done")
                {
                    break;
                }

                for (int i = 0; i < names.Length; i++)
                {
                    if (product == names[i])
                    {
                        Console.WriteLine($"{product} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
            }
        }
    }
}
