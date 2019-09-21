using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab5
{
    class Kurs
    {
        public string Namn { get; set; }
        public int Poang { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }

        public int BeraknaAntalKursDagar()
        {
            int antalDagar = 0;
            var datum = StartDatum.Date;
            while(datum <= SlutDatum.Date)
            {
                if (datum.DayOfWeek != DayOfWeek.Saturday && datum.DayOfWeek != DayOfWeek.Sunday)
                    antalDagar++;
                datum = datum.AddDays(1);
            }
            return antalDagar;
        }

        public int PoangPerKursdag()
        {
            return Poang / BeraknaAntalKursDagar();
        }
    }
}
