using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMethod
{
    public class User
    {
        private const int V = 2500;

        private string Name { get; set; }
        private string Password { get; set; }
        private int UserID { get; set; }  
        
       private static int maas { get; set; }

       static User()
        {
            maas = V;
        }

        public User(string _Name, string _Password, int _UserID)
        {
            Name = _Name;
            Password = _Password;
            UserID = _UserID;
            
        }
        public void Showinfo()
        {
            Console.WriteLine("User info");
            Console.WriteLine(Name);
            Console.WriteLine(Password);
            Console.WriteLine(UserID);
            Console.WriteLine(maas);
        }
        public void Zam(int zammiqdari)
        {
            Console.WriteLine("Zam yapiliyor");
            Console.WriteLine(maas + zammiqdari);
        }
             
    }
}
