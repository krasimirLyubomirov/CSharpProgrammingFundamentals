namespace UnicodeCharacters
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string unicode = String.Empty;

            foreach (char i in input)
            {
                unicode += "\\u" + ((int)i).ToString("x4");
            }

            Console.WriteLine(unicode);
        }
    }
}
