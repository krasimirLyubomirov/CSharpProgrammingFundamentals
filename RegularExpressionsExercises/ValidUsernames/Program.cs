namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();
            Regex regex = new Regex(@"^[A-Za-z][A-Za-z0-9_]{2,24}$");

            foreach (var user in usernames)
            {
                if (regex.IsMatch(user))
                {
                    validUsernames.Add(user);
                }
            }

            int sumLength = 0;
            int maxSumLength = 0;
            int firstUserIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                sumLength = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (sumLength> maxSumLength)
                {
                    maxSumLength = sumLength;
                    firstUserIndex = i;
                }
            }

            Console.WriteLine(validUsernames[firstUserIndex]);
            Console.WriteLine(validUsernames[firstUserIndex + 1]);
        }
    }
}
