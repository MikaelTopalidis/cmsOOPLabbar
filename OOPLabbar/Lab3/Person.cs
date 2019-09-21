using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab3
{
    class Person
    {
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void Namnge(string namn)
        {
            Name = namn; //#När funktion och när property set
                            //I detta fall = property set good enough!
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
       
        public string Name { get; protected set; }
        public string GatuAdress { get; protected set; }
        public string PostNr { get; protected set; }
        public string Postort { get; protected set; }
    }
}
