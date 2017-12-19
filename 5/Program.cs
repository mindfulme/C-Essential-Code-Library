using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Equation
    {
        public double a, b, c, x, x1, x2, D;
        
        public void Result()
        {
            D = b * b - 4 * a * c;

            if (a != 0 && D >= 0)
            {
                x1 = (-b - Math.Sqrt(D)) / 2 * a;
                x2 = (-b + Math.Sqrt(D)) / 2 * a;
                if (x1 != x2)
                    Console.WriteLine("x1={0} x2={1}", x1, x2);
                else
                    Console.WriteLine("x=" + x1);
            }

            else if (a == 0 && b != 0)
            {
                x = -c / b;
                Console.WriteLine("x={0}", x);
            }

            else if (a == 0 && b == 0 || D < 0)
                Console.WriteLine("No roots");

            else if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("No roots");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Equation me = new Equation();
            Console.WriteLine("Enter the value of a");
            me.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            me.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            me.c = Convert.ToDouble(Console.ReadLine());

            me.Result();

            Console.ReadKey();
        }
    }
}
