using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab2
{
    class Lab2
    {
        public void Run()
        {

            var jag = new Person(new DateTime(1972, 8, 3));
            jag.Name = "Stefan Holmberg";
            jag.ChangeAddress("testgatan 1", "12345", "teststad");

            var fru = new Person(new DateTime(1973, 3, 5));
            fru.Name  = "Kerstin Holmberg";
            fru.ChangeAddress("hejgatan 111", "11111", "other");

            jag.MoveInto(fru);
            // jag.ChangeAddress(fru.GatuAdress,fru.PostNr, fru.Postort);
            Console.WriteLine($"jag bor nu på {jag.GatuAdress}");

        }
    }
}
