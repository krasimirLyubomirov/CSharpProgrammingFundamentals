namespace PriceChangeAlert
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = Percent(price, nextPrice);
                bool isSignificantDifference = IsEnoughDifference(difference, threshold);
                string message = GetChange(nextPrice, price, difference, isSignificantDifference);
                Console.WriteLine(message);
                price = nextPrice;
            }
        }

        static string GetChange(double nextPrice, double price, double difference, bool trueOrFalse)
        {
            string change = string.Empty;
            if (difference == 0)
            {
                change = string.Format("NO CHANGE: {0}", nextPrice);
                return change;
            }
            else if (!trueOrFalse)
            {
                change = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return change;
            }
            else if (trueOrFalse && (difference > 0))
            {
                change = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return change;
            }
            else if (trueOrFalse && (difference < 0))
            {
                change = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return change;
            }
            return change;
        }

        static bool IsEnoughDifference(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
                return true;
            }
            return false;
        }

        static double Percent(double price, double nextPrice)
        {
            double difference = (nextPrice - price) / price;
            return difference;
        }
    }
}