using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab6
{
    class Lab6
    {
        private List<Dog> dogs = new List<Dog>();
        public void Run()
        {
            var quit = false;
            while (!quit)
            {
                Console.WriteLine(@"1. Registrera");
                Console.WriteLine("2. Lista");
                Console.WriteLine("3. Ta bort");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Välj->");

                switch (Console.ReadLine())
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Lista();
                        break;
                    case "3":
                        Tabort();
                        break;
                    case "4":
                        quit = true;
                        break;

                }
            }
        }

        private Dog FindDogByName(string name)
        {
            foreach (var dog in dogs)
                if (dog.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return dog;
            return null;
        }

        private void Tabort()
        {
            Console.WriteLine("Ta bort");
            Console.Write("Ange namn->");
            var dog = FindDogByName(Console.ReadLine());
            if (dog == null)
                Console.WriteLine("Hund med det namnet fanns ej i registret");
            else
            {
                dogs.Remove(dog);
                Console.WriteLine("Hunden med det angivna namnet är borttagen");
            }
            //HUR TA BORT ALLA MED SAMMA NAMN?? ???
        }

        private void Lista()
        {
            Console.WriteLine("Lista");
            Console.Write("Ange minsta svanslängd->");
            var langd = Convert.ToDecimal(Console.ReadLine());

            foreach (var dog in dogs)
            {
                if( dog.GetTailLength() >= langd)
                {
                    Console.WriteLine($"{dog.Name} {dog.Type} {dog.Weight} kg svans={dog.GetTailLength()}");
                }
            }
        }

        private void Register()
        {
            Console.WriteLine("Registrera ny hund");

            Console.Write("Ange hundens namn->");
            var name = Console.ReadLine();

            Console.Write("Ange hundens typ->");
            var type = Console.ReadLine();

            Console.Write("Ange hundens ålder->");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange hundens vikt->");
            var weight = Convert.ToInt32(Console.ReadLine());

            var dog = new Dog(name, type, age, weight);
            dogs.Add(dog);
        }
    }
}
