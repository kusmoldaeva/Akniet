using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Student
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

        public override string ToString()
        {
            return this.name + " " + this.surname + " " + this.ID + " " + this.gpa;
             
        }
        }
            class Program
    {
        static void Main(string[] args)
        {

           Student FirstStudent=new Student("Kusmoldaeva", "Akniet", "15BD02053", 4.0 );
            Console.WriteLine(FirstStudent);
            Console.ReadKey();
        }
    
    }
}
