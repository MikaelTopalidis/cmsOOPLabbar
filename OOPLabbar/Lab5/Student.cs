using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab5
{
    class Student
    {
        private List<Kurs> kurser = new List<Kurs>();

        public void AddKurs(Kurs kurs)
        {
            kurser.Add(kurs);
        }

        public string Efternamn { get; set; }
        public string Fornamn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }



    }
}
