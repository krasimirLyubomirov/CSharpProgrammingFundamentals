namespace AndreyAndBilliard
{
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> OrderedProducts { get; set; }

        public Customer(string name)
        {
            this.Name = name;
            this.OrderedProducts = new Dictionary<string, int>();
        }
    }
}
