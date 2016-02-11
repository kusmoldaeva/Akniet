using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Ako1 = new FileStream(@"C:\Users\Акниет\Desktop\Programming technologies\vzlom.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream Ako2 = new FileStream(@"C:\Users\Акниет\Desktop\Programming technologies\password.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
                
            StreamReader sr = new StreamReader(Ako1);
            StreamWriter sr = new StreamWriter(Ako2);

            string[] s = sr.ReadLine().Split();
            long min, max;
            min = long.Parse(s[0]);
            max = long.Parse(s[0]);

            for (int i=0; i<s.Lenght; i++)
            {
                long a = long.Parse(s[0]);

                if(min>=a)

                {
                    min = a;
                }

                if(max<=a)
                {
                    max = a;
                }
            }
            Console.WriteLine("min={0}, max={1}, min, max");

            sr.Close();
            sw.Close();
            Ako1.Close();
            Ako2.Colse();

            Console,ReadKey();
}

    }
}
