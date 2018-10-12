namespace CameraView
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\|<(?<picture>\w+)");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipNumber = numbers[0];
            int takeNumber = numbers[1];
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);

            string[] allResults = new string[matches.Count];
            int index = 0;
            foreach (Match match in matches)
            {
                string currentMatch = match.Groups["picture"].Value;
                char[] resultChars = currentMatch.Skip(skipNumber).Take(takeNumber).ToArray();
                string currnetResult = String.Join("", resultChars);
                allResults[index++] = currnetResult;
            }

            Console.WriteLine(String.Join(", ", allResults));
        }
    }
}
