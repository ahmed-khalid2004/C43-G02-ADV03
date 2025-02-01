using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
   class BookFunctions
    {

        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        public static string GetAuthor(Book book)
        {
            return book.Author;
        }

        public static BookDelegate GetISBN = delegate (Book book)
        {
            return book.ISBN;
        };


        public static Func<Book, string> GetPublicationDate = book => book.PublicationDate.ToShortDateString();
    }

}
