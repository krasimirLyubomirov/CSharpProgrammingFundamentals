namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                if (mailbook.ContainsKey(name) == false)
                {
                    mailbook.Add(name, email);
                }
            }

            foreach (var mail in mailbook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}
