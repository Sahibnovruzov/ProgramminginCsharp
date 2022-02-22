using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.type = "Disi";
            cat.color = "Brown";
            cat.animal = "Boncuk";
            cat.Isim(5);
            cat.showanimal();
            Console.ReadLine();

        }
    }
}
