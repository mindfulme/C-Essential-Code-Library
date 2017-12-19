using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Space
    {
        double[,] dotArr = new double[10, 2]; // массив данных точек
        public double[,] DotArr
        {
            get { return dotArr; }
            set { dotArr = value; }
        }
        public double[] FindPerm()
        {
            double[] ArrMaxPerm = new double[4] { 0, 0, 0, 0 }; // массив ответов (0 - периметр, 1,2,3 - индексы точек)

            for (int indexDot1 = 0; indexDot1 < 10; indexDot1++)
            {
                for (int indexDot2 = indexDot1 + 1; indexDot2 < 10; indexDot2++)
                {
                    for (int indexDot3 = indexDot2 + 1; indexDot3 < 10; indexDot3++)
                    {
                        double vector1X = dotArr[indexDot1, 0] - dotArr[indexDot3, 0]; // находим координаты векторов, для проверки на то, лежать ли 3 точки на одной прямой
                        double vector1Y = dotArr[indexDot1, 1] - dotArr[indexDot3, 1];
                        double vector2X = dotArr[indexDot2, 0] - dotArr[indexDot3, 0];
                        double vector2Y = dotArr[indexDot2, 1] - dotArr[indexDot3, 1];
                        if (vector1X / vector1Y != vector2X / vector2Y) // Проверка на то, лежат ли два вектора на одной прямой
                        {
                            double distanceB = Math.Sqrt((dotArr[indexDot1, 0] - dotArr[indexDot3, 0]) * (dotArr[indexDot1, 0] - dotArr[indexDot3, 0]) + (dotArr[indexDot1, 1] - dotArr[indexDot3, 1]) * (dotArr[indexDot1, 1] - dotArr[indexDot3, 1])); // стороны треугольника 
                            double distanceC = Math.Sqrt((dotArr[indexDot3, 0] - dotArr[indexDot2, 0]) * (dotArr[indexDot3, 0] - dotArr[indexDot2, 0]) + (dotArr[indexDot3, 1] - dotArr[indexDot2, 1]) * (dotArr[indexDot3, 1] - dotArr[indexDot2, 1]));
                            double distanceA = Math.Sqrt((dotArr[indexDot1, 0] - dotArr[indexDot2, 0]) * (dotArr[indexDot1, 0] - dotArr[indexDot2, 0]) + (dotArr[indexDot1, 1] - dotArr[indexDot2, 1]) * (dotArr[indexDot1, 1] - dotArr[indexDot2, 1]));
                            double TempValue = distanceA + distanceB + distanceC;
                            if (TempValue > ArrMaxPerm[0]) // 
                            {
                                ArrMaxPerm[0] = TempValue;
                                ArrMaxPerm[1] = indexDot1;
                                ArrMaxPerm[2] = indexDot2;
                                ArrMaxPerm[3] = indexDot3;
                            }
                        }
                    }
                }
            }
            return ArrMaxPerm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Space space = new Space();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter X coordinate of the point {0}", i + 1);
                space.DotArr[i, 0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Y coordinate of the point {0}", i + 1);
                space.DotArr[i, 1] = Convert.ToDouble(Console.ReadLine());
            }
            double[] triangle = space.FindPerm();
            Console.WriteLine("Max perim: {0}", triangle[0]);
            for (int var = 1; var <= 3; var++)
            {
                Console.WriteLine("Tip {0}: {1}, {2}", var, space.DotArr[Convert.ToInt32(triangle[var]), 0], space.DotArr[Convert.ToInt32(triangle[var]), 1]);
            }
            Console.ReadKey();

        }
    }
}