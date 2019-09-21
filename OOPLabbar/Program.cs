using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar
{
    class Program
    {
        static void Main(string[] args)
        {
            var lab6 = new Lab6.Lab6();
            lab6.Run();

            var lab5 = new Lab5.Lab5();
            lab5.Run();

            var lab = new Lab1.Lab1();
            lab.Run();
            var lab2 = new Lab2.Lab2();
            lab2.Run();
            var lab3 = new Lab3.Lab3();
            lab3.Run();
            var lab4 = new Lab4.Lab4();
            lab4.Run();

            Console.ReadLine();

        }
    }
}
