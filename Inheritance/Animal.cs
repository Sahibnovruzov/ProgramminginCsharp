using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string animal;
        public string type;
        public string color;
        private int age;

        public void Isim(int _age)
        {
            age = _age;
        
        }


        public void showanimal()
        {
            Console.WriteLine(animal);
            Console.WriteLine(type);
            Console.WriteLine(color);
            Console.WriteLine(age);
        }
    }
}
