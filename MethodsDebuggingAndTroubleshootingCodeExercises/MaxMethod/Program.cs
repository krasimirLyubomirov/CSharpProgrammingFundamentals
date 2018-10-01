namespace MaxMethod
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            max = GetMax(max, thirdNumber);

            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);

            return max;
        }
    }
}
