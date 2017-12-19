using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{   class Sum
    {
        public int num,sum;
        public void SumOfDigits()
        {
            sum = num / 100 + (num % 100) / 10 + num % 10;
            Console.WriteLine("A sum of the element {0} equal to {1}", num, sum);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Sum me = new Sum();
            Console.WriteLine("Enter an even number(>99)");
            me.num = Convert.ToInt32(Console.ReadLine());

            me.SumOfDigits();

            Console.ReadKey();
        }
    }
}
