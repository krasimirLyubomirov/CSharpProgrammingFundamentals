namespace Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] tokens = line.Split(" @");

                if (tokens.Length != 2)
                {
                    continue;
                }

                string singerName = tokens[0];
                string[] venueAndTicketsTokens = tokens[1].Split();

                if (venueAndTicketsTokens.Length < 3)
                {
                    continue;
                }

                bool hasTicketCount = 
                    int.TryParse(venueAndTicketsTokens[venueAndTicketsTokens.Length - 1], out int ticketCount);
                bool hasTicketPrice = 
                    int.TryParse(venueAndTicketsTokens[venueAndTicketsTokens.Length - 2], out int ticketPrice);

                if (hasTicketCount == false || hasTicketPrice == false)
                {
                    continue;
                }

                string venueName = GetVenueName(venueAndTicketsTokens);

                if (venues.ContainsKey(venueName) == false)
                {
                    venues.Add(venueName, new Dictionary<string, int>());
                }

                if (venues[venueName].ContainsKey(singerName) == false)
                {
                    venues[venueName].Add(singerName, 0);
                }

                venues[venueName][singerName] += ticketPrice * ticketCount;
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        private static string GetVenueName(string[] tokens)
        {
            string venue = string.Empty;
            for (int i = 0; i < tokens.Length - 2; i++)
            {
                venue += tokens[i] + " ";
            }

            return venue.TrimEnd();
        }
    }
}
