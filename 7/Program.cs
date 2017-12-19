using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            ulong sum=0;
            Console.WriteLine("Enter the number");
            n = Convert.ToUInt32(Console.ReadLine());

            while(n>0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine(sum);
            Console.ReadKey();



        }
    }
}
