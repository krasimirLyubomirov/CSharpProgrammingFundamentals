namespace MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\+359(-?|\s)?2\1\d{3}\1\d{4}\b");

            MatchCollection matches = regex.Matches(input);
            string[] matchedPhone = matches.Cast<Match>().Select(e => e.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matchedPhone));
        }
    }
}
