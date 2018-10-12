namespace KeyReplacer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            Regex keyRegex = new Regex(@"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$");
            Match match = keyRegex.Match(key);

            if (match.Success)
            {
                string startKey = match.Groups["startKey"].Value;
                string endKey = match.Groups["endKey"].Value;
                string wordInText = @"(?<word>.*?)";

                Regex textRegex = new Regex($"{startKey}{wordInText}{endKey}");
                MatchCollection matches = textRegex.Matches(text);

                StringBuilder result = new StringBuilder();
                foreach (Match item in matches)
                {
                    result.Append(item.Groups["word"].Value);
                }

                if (result.ToString().Length == 0)
                {
                    Console.WriteLine("Empty result");
                }
                else
                {
                    Console.WriteLine(result.ToString());
                }
            }
        }
    }
}
