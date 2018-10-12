namespace ExtractEmails
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\s[A-Za-z0-9]+([._-][A-Za-z0-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+");
            MatchCollection matches = regex.Matches(input);
            string[] match = matches.Cast<Match>().Select(e => e.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, match));
        }
    }
}
