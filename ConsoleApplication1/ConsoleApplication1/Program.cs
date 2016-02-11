using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
            return c3;
        }
        public override string ToString()
            {
                return a + " " + "and" + " " + b;

            }

        }
        class program
        {
            static void Main(String[] args)
            {
                Complex First = new Complex(12, 25);
                Complex Second = new Complex(26, 85);
                Complex answer = First + Second;
                Console.WriteLine(answer);
                Console.ReadKey();

            }
        }
    
}
