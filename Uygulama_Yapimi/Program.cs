using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uygulama_Yapimi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            bool control = true;
            Showchanges();

            Student_Program student = new Student_Program("Sahib", "Novruzov", "Ali mekteb", 185
                , 75, 32, 22);

            Console.WriteLine("Programa xoş gəldiniz");
            while (control)
            {

                string choose = Console.ReadLine();


                switch (choose)
                {
                    case "1":
                        student.Studend_info();
                        break;
                    case "2":
                 double Studentaver = student.Student_average();
                        Console.WriteLine("Student's average" + Studentaver);
                        break;
                    case "3":
                        student.School();
                        break;
                    case "4":
                        control = false;    
                        break;

                }
            }
     
        }

        static void Showchanges()
        {
            Console.WriteLine("1. Show student informatin ");
            Console.WriteLine("2. Show student average ");
            Console.WriteLine("3. Show student school ");
            Console.WriteLine("4. Exit ");
        }

    }
}
