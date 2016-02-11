using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        static void Main(string[] args)
        {
            public string name;
        public string surname;
        public string ID;
        public double gpa;

        public Student(string name, string surname,string ID,double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.ID = ID;
            this.gpa = gpa;
        }
        public overright string ToString()
        {
            return name + " " + surname + " " + gpa + " " + ID;
             
        }
        }
            class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            double gpa = Convert.ToDouble(Console.ReadLine());
            string ID = Console.ReadLine();
            Student info = new Student(name, surname, gpa, ID);
            Console.ReadLine(Info);
            Console.ReadKey;
        }
    }
    }
}
