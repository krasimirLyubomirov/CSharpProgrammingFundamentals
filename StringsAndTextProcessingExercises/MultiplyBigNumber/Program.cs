namespace MultiplyBigNumber
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(numAsString[i].ToString());

                int currentSum = digit * multiplier + remainder;
                remainder = currentSum / 10;

                result.Append(currentSum % 10);
            }

            result.Append(remainder);
            string output = result.ToString().TrimEnd('0');

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }

            Console.WriteLine();
        }
    }
}
