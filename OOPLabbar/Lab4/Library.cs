using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab4
{
    class Library
    {
        private List<Book> books = new List<Book>();

        internal void LoanOutTitle(string title)
        {
            var existing = GetBookByTitle(title);
            //if (existing.BorrowedCount == 0 etc etc)
            existing.LoanOutTitle();
        }

        internal void ReturnTitle(string title)
        {
            var existing = GetBookByTitle(title);
            existing.ReturnOneEx();
        }

        internal void AddTitle(string title)
        {
            var existing = GetBookByTitle(title);
            if (existing != null)
                existing.AddAnotherEx();
            else
            {
                var newBook = new Book(title);
                newBook.AddAnotherEx();
                books.Add(newBook);
            }

        }
        private Book GetBookByTitle(string title)
        {
            foreach (var book in books)
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return book;
            return null;
        }

    }
}
