namespace smsTyping
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {numOne}");
            Console.WriteLine($"b = {numTwo}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {numTwo}");
            Console.WriteLine($"b = {numOne}");
        }
    }
}
