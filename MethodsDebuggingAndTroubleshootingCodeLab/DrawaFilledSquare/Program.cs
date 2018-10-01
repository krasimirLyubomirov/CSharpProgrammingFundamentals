namespace DrawaFilledSquare
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintHeader(num);
            PrintMiddle(num);
            PrintHeader(num);
        }
        
        static void PrintHeader(int n)
        {
            Console.WriteLine("{0}", new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('-');

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
