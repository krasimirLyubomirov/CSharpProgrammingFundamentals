namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string productName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (product == null)
                {
                    Product newProduct = new Product(productName, price);
                    products.Add(newProduct);
                }
                else
                {
                    product.Price = price;
                }
            }

            List<Customer> customers = new List<Customer>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of clients")
                {
                    break;
                }

                string[] tokens = line.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string customerName = tokens[0];
                string productName = tokens[1];
                int productQuantity = int.Parse(tokens[2]);

                if (!products.Any(p => p.Name == productName))
                    continue;

                Customer customer = customers.FirstOrDefault(c => c.Name == customerName);

                if (customer == null)
                {
                    Customer newCustomer = new Customer(customerName);
                    newCustomer.OrderedProducts.Add(productName, productQuantity);
                    customers.Add(newCustomer);
                }
                else
                {
                    if (customer.OrderedProducts.ContainsKey(productName) == false)
                    {
                        customer.OrderedProducts.Add(productName, productQuantity);
                    }
                    else
                    {
                        customer.OrderedProducts[productName] += productQuantity;
                    }
                }
            }

            decimal totalBill = 0; 
            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                decimal bill = 0;

                foreach (var orderedProduct in customer.OrderedProducts)
                {
                    Console.WriteLine($"-- {orderedProduct.Key} - {orderedProduct.Value}");

                    string productName = orderedProduct.Key;
                    int quantity = orderedProduct.Value;
                    decimal price = products.First(p => p.Name == productName).Price;
                    bill += quantity * price;
                }

                totalBill += bill;
                Console.WriteLine($"Bill: {bill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    } 
}
