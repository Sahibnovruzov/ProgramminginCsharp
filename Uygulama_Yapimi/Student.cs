using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Yapimi
{
    
    public class Student_Program
    {
        
        private string name;
        private string surname;
        private string school;
        private int exam1;
        private int exam2;
        private int student;
        private int final;

        public Student_Program(string _name, string _surname, string _school, int _student, int _exam1, int _exam2, int _final)
        {
            name = _name;
            surname = _surname;
            school = _school;
            exam1 = _exam1;
            exam2 = _exam2;
            student = _student;
            final = _final;

        }

        public void Studend_info()
        {
            Console.WriteLine($"Student name : {name}");
            Console.WriteLine($"Student surname : {surname}");
            Console.WriteLine($"Student school : {school}");
            Console.WriteLine($"Student student : {student}");
            Console.WriteLine($"Student exam1 : {exam1}");
            Console.WriteLine($"Student exam2 : {exam2}");
            Console.WriteLine($"Student final : {final}");
        }
        public double Student_average()
        {
            double average = exam1 * 0.2 + exam2 * 0.2 + final * 0.6;
            return average;
        } 
        public void School()
        {
            Console.WriteLine($"Student school : {school}");
        }
    }
}
