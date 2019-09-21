using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab5
{
    class Larare
    {
        private List<Kurs> ansvarigForKurser;
        public Larare()
        {
            ansvarigForKurser = new List<Kurs>();
        }
        public string Email { get; set; }
        public string Namn { get; set; }
        public string Telefon { get; set; }

        public List<Kurs> AnsvarigForKurser()
        {
            return ansvarigForKurser;
        }

        internal void AddKurs(Kurs kurs)
        {
            ansvarigForKurser.Add(kurs);
        }
    }
}
