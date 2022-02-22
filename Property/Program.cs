using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Program
    {
        static void Main(string[] args)
        {
           Personel personel = new Personel();
            personel.AZKIMLIK = "12345678998";
            Console.WriteLine("Kimlik nomreniz " + personel.AZKIMLIK);
            Console.ReadLine();
        }
    }
}
