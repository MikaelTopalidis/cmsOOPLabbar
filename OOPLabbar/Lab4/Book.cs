using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab4
{
    class Book
    {
        public Book(string title)
        {
            Title = title;
            TotalCount = 0;
            BorrowedCount = 0;
        }
        public string Title { get; set; }
        public int TotalCount { get; protected set; }

        internal void LoanOutTitle()
        {
            if (TotalCount > BorrowedCount)
                BorrowedCount++;
        }

        internal void ReturnOneEx()
        {
            if (BorrowedCount > 0)
                BorrowedCount--;
        }

        internal void AddAnotherEx()
        {
            TotalCount++;
        }

        public int BorrowedCount { get; set; }

        public int GetCountInLibrary()
        {
            return TotalCount - BorrowedCount;
        }

    }
}
