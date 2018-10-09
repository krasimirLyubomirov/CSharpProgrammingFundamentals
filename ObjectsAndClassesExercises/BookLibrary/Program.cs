namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime realeaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, realeaseDate, isbn, price);
                books.Add(book);
            }

            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (var book in books)
            {
                string authorName = book.Author;
                decimal price = book.Price;

                if (authors.ContainsKey(authorName) == false)
                {
                    authors.Add(authorName, price);
                }
                else
                {
                    authors[authorName] += price;
                }
            }

            Dictionary<string, decimal> sortedAuthors = authors.OrderByDescending(a => a.Value).ThenBy(a => a.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var author in sortedAuthors)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
