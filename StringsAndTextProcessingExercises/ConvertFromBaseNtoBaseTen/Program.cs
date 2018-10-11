namespace ConvertFromBaseNtoBaseTen
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            string[] Tokens = Console.ReadLine().Split();

            int @base = int.Parse(Tokens[0]);
            string numAsString = Tokens[1];

            BigInteger sum = 0;
            int pow = 0;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currentChar = numAsString[i];
                int currentNumber = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
                sum += currentSum;
                pow++;
            }

            Console.WriteLine(sum);
        }
    }
}
