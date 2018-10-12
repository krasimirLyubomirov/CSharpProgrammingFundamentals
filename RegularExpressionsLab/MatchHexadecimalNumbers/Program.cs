namespace MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(0x)?[0-9A-F]+\b");
            MatchCollection matches = regex.Matches(input);

            string[] match = matches.Cast<Match>().Select(e => e.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(" ", match));
        }
    }
}
