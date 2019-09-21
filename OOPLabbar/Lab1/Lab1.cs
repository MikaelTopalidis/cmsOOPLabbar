using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab1
{
    class Lab1
    {
        public void Run()
        {
            var pannkakor = new MatRatt
            {
                AntalKalorier = 10,
                MatTyp = MatTyp.Ospecificerat,
                Namn = "Pannkakor",
                Pris = 59m
            };

            var hamburgare = new MatRatt
            {
                AntalKalorier = 100,
                MatTyp = MatTyp.Kott,
                Namn = "Hamburgare",
                Pris = 69m
            };

            var soppa = new MatRatt
            {
                AntalKalorier = 30,
                MatTyp = MatTyp.Vegetariskt,
                Namn = "Purjolökssoppa",
                Pris = 49m
            };

            var matRatter = new List<MatRatt>();
            matRatter.Add(soppa);
            matRatter.Add(pannkakor);
            matRatter.Add(hamburgare);


            foreach (var matRatt in matRatter)
            {
                Console.WriteLine($"{matRatt.Namn} {matRatt.Pris}");
            }

            ////Vegan
            //foreach (var matRatt in matRatter.Where(m=>m.MatTyp == MatTyp.Veganskt))
            //{
            //    Console.WriteLine($"{matRatt.Namn} {matRatt.Pris}");
            //}


        }
    }
}
