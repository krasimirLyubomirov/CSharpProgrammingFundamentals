namespace specialNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long l;

            if (long.TryParse(number, out l))
            {
                Console.WriteLine($"{number} can fit in:");

                sbyte s; byte b; short sh; ushort us; int i; uint ui;

                if (sbyte.TryParse(number, out s))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(number, out b))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(number, out sh))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(number, out us))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(number, out i))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(number, out ui))
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
