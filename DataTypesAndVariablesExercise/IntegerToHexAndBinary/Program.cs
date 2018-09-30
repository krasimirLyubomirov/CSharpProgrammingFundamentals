namespace specialNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            string hexaDecimal = Convert.ToString(value, 16).ToUpper();
            string binary = Convert.ToString(value, 2);

            Console.WriteLine(hexaDecimal);
            Console.WriteLine(binary);
        }
    }
}
