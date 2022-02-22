using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please add name :");
            Student student = new Student();
            student.setname(Console.ReadLine());
          string Response = student.getname();
            if (Response=="Sahib")
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Uncomplete");
            }
            Console.ReadLine();
        }
    }
}
