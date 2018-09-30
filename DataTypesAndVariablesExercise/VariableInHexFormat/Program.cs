namespace smsTyping
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(number, 16));
        }
    }
}
