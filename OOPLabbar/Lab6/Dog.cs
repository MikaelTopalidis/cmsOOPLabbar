using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabbar.Lab6
{
    class Dog
    {
        public Dog(string name, string type, int age, int weight)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        internal decimal GetTailLength()
        {
            if (Type.ToLower() == "tax") return 3.7m;
            return Convert.ToDecimal(Age) * Convert.ToDecimal(Weight) / 10.0m;
        }
    }
}
