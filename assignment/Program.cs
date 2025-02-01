using System;
using System.Collections.Generic;
namespace assignment
{

    // User-Defined Delegate
    delegate string BookDelegate(Book book);

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
    }

    class BookFunctions
    {
        // Using a User-Defined Delegate
        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        // Using BCL Delegate (Func<T, TResult>)
        public static string GetAuthor(Book book)
        {
            return book.Author;
        }

        // Using an Anonymous Method for GetISBN
        public static BookDelegate GetISBN = delegate (Book book)
        {
            return book.ISBN;
        };

        // Using a Lambda Expression for GetPublicationDate
        public static Func<Book, string> GetPublicationDate = book => book.PublicationDate.ToShortDateString();
    }

    class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookDelegate fPtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        static void Main()
        {
            List<Book> books = new List<Book>
        {
            new Book { Title = "C# Fundamentals", Author = "John Doe", ISBN = "123-456789", PublicationDate = new DateTime(2020, 5, 1) },
            new Book { Title = "Advanced C#", Author = "Jane Smith", ISBN = "987-654321", PublicationDate = new DateTime(2021, 7, 15) }
        };

            Console.WriteLine("Titles:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            Console.WriteLine("Authors:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthor);

            Console.WriteLine("ISBNs:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetISBN);

            Console.WriteLine("Publication Dates:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPublicationDate);
        }
    }
}

