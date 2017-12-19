using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Equation
    {
        public int a;
        public int b;
        public int x;

        public void Result()
        {
            if (a != 0)
            {
                x = b / a;
                Console.WriteLine("x="+x);
            }
            else if (a == 0 && b == 0) 
            {
                Console.WriteLine("Too many roots");
            }
            else if (a == 0)
            {
               Console.WriteLine("No roots");
            } 
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Equation me = new Equation();
            Console.WriteLine("Enter the value of a");
            me.a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            me.b = Convert.ToInt32(Console.ReadLine());

            me.Result();

            Console.ReadKey();
        }
    }
}
