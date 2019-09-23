using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab4
{
    class Lab4
    {
        Library library = new Library();

        public void Run()
        {
            while(true)
            {
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Låna ut bok");
                Console.WriteLine("3. Lämna tillbaka bok");
                var sel = Console.ReadLine();
                if(sel == "1")
                {
                    AddBook();
                }
                else if (sel == "2")
                {
                    LoanOutBook();
                }
                else if (sel == "3")
                {
                    ReturnBook();
                }
            }
        }

        private void ReturnBook()
        {
            Console.WriteLine("Ange namn");
            var title = Console.ReadLine();
            library.ReturnTitle(title);
        }

        private void LoanOutBook()
        {
            Console.WriteLine("Ange namn");
            var title = Console.ReadLine();
            library.LoanOutTitle(title);
        }

        private void AddBook()
        {
            Console.WriteLine("Ange namn");
            var title = Console.ReadLine();
            library.AddTitle(title);
        }
    }
}
