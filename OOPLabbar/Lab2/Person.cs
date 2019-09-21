using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab2
{
    class Person
    {
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public void ChangeAddress(string gatuAdress, string postNr, string postOrt)
        {
            GatuAdress = gatuAdress;
            PostNr = postNr;
            Postort = postOrt;
        }


        internal void MoveInto(Person other)
        {
            this.ChangeAddress(other.GatuAdress, other.PostNr, other.Postort);
        }

        public DateTime BirthDate { get; protected set; }
       
        public string Name { get; set; }
        public string GatuAdress { get; protected set; }
        public string PostNr { get; protected set; }
        public string Postort { get; protected set; }
    }
}
