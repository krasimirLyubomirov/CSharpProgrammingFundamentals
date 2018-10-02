namespace UpgradedMatcher
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

            long quantity = 0;
            decimal costs = 0;

            while (true)
            {
                string[] product = Console.ReadLine().Split();

                if (product[0] == "done")
                {
                    break;
                }


                for (int i = 0; i < names.Length; i++)
                {
                    if (product[0] == names[i])
                    {
                        try
                        {
                            if (long.TryParse(product[1], out quantity))
                            {
                                if (quantity <= quantities[i])
                                {
                                    costs = quantity * prices[i];
                                    Console.WriteLine($"{product[0]} x {quantity} costs {costs:f2}");
                                    quantities[i] -= quantity;
                                    costs = 0;
                                }
                                else
                                {
                                    Console.WriteLine($"We do not have enough {product[0]}");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"We do not have enough {product[0]}");
                        }
                    }
                }
            }
        }
    }
}
