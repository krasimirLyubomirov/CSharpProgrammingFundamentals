namespace ExactSumOfRealNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            decimal exactSum = 0;

            for (int i = 1; i <= nums; i++)
            {
                decimal exactNum = decimal.Parse(Console.ReadLine());
                exactSum = exactSum + exactNum;
            }

            Console.WriteLine(exactSum);
        }
    }
}
