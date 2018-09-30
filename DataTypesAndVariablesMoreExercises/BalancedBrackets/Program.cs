namespace BalancedBrackets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string last = string.Empty;
            string balanced = "BALANCED";

            for (int i = 1; i <= num; i++)
            {
                string random = Console.ReadLine();

                if (random == "(")
                {
                    if (last == "(")
                    {
                        balanced = "UNBALANCED";
                        break;
                    }

                    last = "(";
                }

                if (random == ")")
                {
                    if (last != "(")
                    {
                        balanced = "UNBALANCED";
                        break;
                    }

                    last = ")";
                }
            }

            if (last == "(")
            {
                balanced = "UNBALANCED";
            }

            Console.WriteLine(balanced);
        }
    }
}
