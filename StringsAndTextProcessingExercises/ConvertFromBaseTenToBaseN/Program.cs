namespace ConvertFromBaseTenToBaseN
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split();

            int @base = int.Parse(inputTokens[0]);
            BigInteger number = BigInteger.Parse(inputTokens[1]);

            StringBuilder converted = new StringBuilder();

            while (number > 0)
            {
                BigInteger remainder = number % @base;

                converted.Append(remainder);

                number /= @base;

            }

            string reverse = string.Join("", converted.ToString().Reverse());
            Console.WriteLine(reverse);
        }
    }
}
