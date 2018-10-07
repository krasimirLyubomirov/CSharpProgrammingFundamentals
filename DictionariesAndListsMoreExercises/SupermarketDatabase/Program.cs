namespace SupermarketDatabase
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> productAndQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "stocked")
                {
                    break;
                }

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (productAndQuantity.ContainsKey(name) == false)
                {
                    productAndQuantity[name] = 0;
                    productAndPrice[name] = price;
                }

                productAndQuantity[name] += quantity;
                productAndPrice[name] = price;
            }

            double totalPrice = 0;
            double productPrice = 0;

            foreach (var product in productAndPrice)
            {
                foreach (var quantity in productAndQuantity)
                {
                    if (product.Key == quantity.Key)
                    {
                        productPrice = product.Value * quantity.Value;
                        totalPrice += productPrice;
                        Console.WriteLine($"{product.Key}: ${product.Value:f2} * {quantity.Value} = ${productPrice:f2}");
                    }

                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalPrice:f2}");
        }
    }
}
