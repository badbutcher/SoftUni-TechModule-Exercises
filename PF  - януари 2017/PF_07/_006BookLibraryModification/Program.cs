namespace _006BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            Book book = new Book();
            List<Book> books = new List<Book>();
            Dictionary<string, double> result = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var title = book.Title = input[0];
                var author = book.Author = input[1];
                var publisher = book.Publisher = input[2];
                var releaseDate = book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var number = book.ISBNNumber = int.Parse(input[4]);
                var price = book.Price = double.Parse(input[5]);

                Book bookToAdd = new Book() { Title = title, Author = author, Publisher = publisher, ReleaseDate = releaseDate, ISBNNumber = number, Price = price };
                books.Add(bookToAdd);
            }

            library.Books = books;

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var sort = books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title);
            foreach (var item in sort)
            {
                if (date < item.ReleaseDate)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Title, item.ReleaseDate);
                }
            }
        }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int ISBNNumber { get; set; }

        public double Price { get; set; }
    }
}