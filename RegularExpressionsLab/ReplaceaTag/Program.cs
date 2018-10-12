namespace ReplaceaTag
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                Regex regex = new Regex("(\\s*)<a href=\"(.*?)\">(.*?)<\\/a>(\\s*)");

                input = regex.Replace(input, "$1[URL href=\"$2\"]$3[/URL]$4");
                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
