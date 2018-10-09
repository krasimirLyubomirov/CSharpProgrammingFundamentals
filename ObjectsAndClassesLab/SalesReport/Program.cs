namespace SalesReport
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            SortedDictionary<string, decimal> totalSalesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string town = data[0];
                string product = data[1];
                decimal price = decimal.Parse(data[2]);
                decimal quantity = decimal.Parse(data[3]);

                Sale sale = new Sale(town, product, price, quantity);
                sales.Add(sale);
            }

            foreach (var sale in sales)
            {
                if (totalSalesByTown.ContainsKey(sale.Town) == false)
                {
                    totalSalesByTown.Add(sale.Town, sale.Multiply());
                }
                else
                {
                    totalSalesByTown[sale.Town] += sale.Multiply();
                }
            }

            foreach (var item in totalSalesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
