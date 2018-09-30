namespace NumberChecker
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long intValue;
            float floatValue;

            if (long.TryParse(s, out intValue))
            {
                Console.WriteLine("integer");
            }
            else if (float.TryParse(s, out floatValue))
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
