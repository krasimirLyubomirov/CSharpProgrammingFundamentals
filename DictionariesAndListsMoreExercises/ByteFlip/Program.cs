﻿namespace ByteFlip
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] byteArray = Console.ReadLine().Split().Where(x => x.Length == 2).ToArray();

            for (int i = byteArray.Length - 1; i >= 0; i--)
            {
                char[] charArray = byteArray[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(Convert.ToChar(Convert.ToUInt32(new string(charArray), 16)));
            }

            Console.WriteLine();
        }
    }
}
