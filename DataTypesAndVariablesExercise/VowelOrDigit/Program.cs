namespace specialNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string vowel = Console.ReadLine().ToLower();

            int value;

            if (int.TryParse(vowel, out value))
            {
                Console.WriteLine("digit");
            }
            else if (vowel == "a" || vowel == "e" || vowel == "i" || vowel == "o" || vowel == "u" || vowel == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
