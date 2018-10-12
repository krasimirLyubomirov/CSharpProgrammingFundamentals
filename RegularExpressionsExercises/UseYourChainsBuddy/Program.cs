namespace UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=<p>).*?(?=<\/p>)");
            MatchCollection matches = regex.Matches(input);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (Match match in matches)
            {
                string replaced = Regex.Replace(match.ToString(), "[^a-z0-9]", " ");
                for (var i = 0; i < replaced.Length; i++)
                {
                    char letter = replaced[i];
                    if (char.IsLower(replaced[i]))
                    {
                        if (replaced[i] < 110)
                        {
                            stringBuilder.Append((char)(letter + 13));
                        }
                        else if (replaced[i] >= 110)
                        {
                            stringBuilder.Append((char)(letter - 13));
                        }
                    }
                    else
                    {
                        stringBuilder.Append(replaced[i]);
                    }
                }
            }

            Console.WriteLine(Regex.Replace(stringBuilder.ToString(), @"\s+", " "));
        }
    }
}
