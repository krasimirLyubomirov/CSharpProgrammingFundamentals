namespace HouseBuilder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long priceOne = long.Parse(Console.ReadLine());
            long priceTwo = long.Parse(Console.ReadLine());

            long sbytePrice = 0;
            long intPrice = 0;

            if (priceOne < 128)
            {
                sbytePrice = priceOne * 4;
                intPrice = priceTwo * 10;
            }
            else if (priceTwo < 128)
            {
                sbytePrice = priceTwo * 4;
                intPrice = priceOne * 10;
            }

            decimal totalPrice = sbytePrice + intPrice;
            Console.WriteLine(totalPrice);
        }
    }
}
