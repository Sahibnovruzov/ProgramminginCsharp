using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylistnew
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList collection = new ArrayList();

            collection.Add("Enes");
            collection.Add("Sahib");
            collection.Add("Eli");
            collection.Add("Saleh");
            //collection.Remove("Saleh");
            //int b = collection.Count;
            //collection.Clear();
            //bool control = collection.Contains("Saleh");
            //int b = collection.IndexOf("Eli");
            //collection.Insert(1, "Heyder");
            //collection.Reverse();
            collection.Sort();


            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            */
            var myarray = new ArrayList();  
            myarray.Add(32);
            myarray.Add(5);
            myarray.Add(43);
            myarray.Add(72);
            myarray.Add(22);
            myarray.Sort();
            foreach (var a in myarray)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
