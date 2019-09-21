using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab3
{
    class Lab3
    {
        public void Run()
        {
            var jag = new Person(new DateTime(1972, 8, 3));
            Console.WriteLine($"jag är (ca) {jag.GetAge()}");

            var fru = new Person(new DateTime(1973, 3, 5));
            Console.WriteLine($"fru är (ca) {fru.GetAge()}");

        }
    }
}
