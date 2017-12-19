using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    public struct Money
    {
        public uint grn;
        public uint kop;
        public static uint[] Sum(Money cash_1, Money cash_2)
        {
            uint[] sum = new uint[2];
            sum[0] = cash_1.grn + cash_2.grn;
            sum[1] = cash_1.kop + cash_2.kop;
            if (sum[1] > 99)
            {
                sum[1] -= 100;
                sum[0] += 1;
            }

            return sum;
        }
        public static uint[] Diff(Money cash_1, Money cash_2)
        {
            uint[] diff = new uint[2];
            if (cash_1.grn > cash_2.grn && cash_2.kop > cash_1.kop)
            {
                diff[0] = cash_1.grn - cash_2.grn - 1;
                diff[1] = 100 - cash_2.kop + cash_1.kop;
            }
            else if (cash_1.grn < cash_2.grn && cash_1.kop > cash_2.kop)
            {
                diff[0] = cash_2.grn - cash_1.grn - 1;
                diff[1] = 100 - cash_1.kop + cash_2.kop;
            }
            else
            {
                diff[0] = Convert.ToUInt32(Math.Abs(cash_1.grn - cash_2.grn));
                diff[1] = Convert.ToUInt32(Math.Abs(cash_2.kop - cash_1.kop));
            }
            return diff;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money cash_1;
            Money cash_2;
            Console.WriteLine("UAN of the first sum:");
            cash_1.grn = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Coins of the first sum:");
            cash_1.kop = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("UAN of the second:");
            cash_2.grn = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Coins of the second sum:");
            cash_2.kop = Convert.ToUInt32(Console.ReadLine());
            uint[] sum = Money.Sum(cash_1, cash_2);
            uint[] diff = Money.Diff(cash_1, cash_2);
            Console.WriteLine(sum[0] + " " + sum[1]);
            Console.WriteLine(diff[0] + " " + diff[1]);
            Console.ReadKey();
        }
    }
}
