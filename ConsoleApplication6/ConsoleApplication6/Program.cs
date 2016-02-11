using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {


    class Program
        {
            static void Main(string[] args)
            {
                FileStream fs = new FileStream(@"C:\Users\Акниет\Desktop\Programming technologies\password.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream fs1 = new FileStream(@"C:\Users\Акниет\Desktop\Programming technologies\vzlom.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs1);

                string[] s = sr.ReadLine().Split();
                int a;
                List<int> primes = new List<int>();

                for (int i = 0; i < s.Length; i++)
                {
                    a = int.Parse(s[i]);
                    int counter = 0;

                    for (int j = 1; j <= a; j++)
                    {
                        if (a % j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter < 3)
                    {
                        primes.Add(a);
                    }
                }
               
                sw.WriteLine("Min prime number = {0}", primes.Min()); 
                

                sr.Close();
                sw.Close();
                fs1.Close();
                fs.Close();

                Console.ReadKey();
            }
    }
}
