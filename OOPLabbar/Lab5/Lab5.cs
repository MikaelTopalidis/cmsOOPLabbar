using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab5
{
    class Lab5
    {
        public void Run()
        {
            var kurs = new Kurs {
                Namn = "CMS",
                Poang = 200,
                StartDatum = new DateTime(2019,8,22),
                SlutDatum = new DateTime(2019, 10, 29),
            };
            var annanKurs = new Kurs
            {
                Namn = "IOT",
                Poang = 150,
                StartDatum = new DateTime(2019, 7, 08),
                SlutDatum = new DateTime(2019, 11, 01),
            };

            var student1 = new Student
            {
                Fornamn = "Josefine",
                Efternamn = "Holmberg",
                Email = "j@j.se",
                Telefon = "08-1213132123"
            };

            var student2 = new Student
            {
                Fornamn = "Oliver",
                Efternamn = "Holmberg",
                Email = "o@j.se",
                Telefon = "08-1213132123"
            };

            var teacher = new Larare
            {   Namn = "Stefan Holmberg",
                Email = "s@s.se",
                Telefon = "08-1213132123"
            };

            teacher.AddKurs(kurs);
            teacher.AddKurs(annanKurs);
            student1.AddKurs(kurs);
            student2.AddKurs(kurs);
            student2.AddKurs(annanKurs);

            Console.WriteLine($"{kurs.Namn} {kurs.BeraknaAntalKursDagar()} {kurs.PoangPerKursdag()} ");
            Console.WriteLine($"{annanKurs.Namn} {annanKurs.BeraknaAntalKursDagar()} {annanKurs.PoangPerKursdag()} ");


        }
    }
}
