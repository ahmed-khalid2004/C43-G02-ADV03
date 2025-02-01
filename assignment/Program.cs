using System;
using System.Collections.Generic;
namespace assignment
{
    // User-Defined Delegate
    delegate string BookDelegate(Book book);
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Author = "Ahmed Khalid", ISBN = "01110871987", PublicationDate = new DateTime(2024, 9,25) },
            new Book { Title = "C# OOP", Author = "Abdallah", ISBN = "01234567890", PublicationDate = new DateTime(2024, 12, 11) }
        };

            Console.WriteLine("Titles:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            Console.WriteLine("Authors:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthor);

            Console.WriteLine("ISBNs:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetISBN);

            Console.WriteLine("Publication Dates:");
            LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetPublicationDate));

        }
    }
}
