using System;
using System.Linq;
using EF_Core.Lib;

namespace EF_Core.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BookStoreDB();

            var authors = db.TabAuthors.ToList();
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Id}: {author.LastName} {author.FirstName}");

                var books = author.TabBooks.ToList();
                foreach (var book in books)
                {
                    Console.WriteLine($"\t{book.Id}: {book.Title}, {book.YearOfCreation}, {book.IdGenreNavigation.Name}");
                }
            }
        }
    }
}