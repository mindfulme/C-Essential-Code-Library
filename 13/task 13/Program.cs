using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Matrix
    {
        public int[,] Transp(int[,] matrix, int str, int colum)
        {
            int[,] transpMatrix = new int[colum, str];
            for (int i = 0; i < colum; i++)
            {
                for (int v = 0; v < str; v++)
                {
                    transpMatrix[i, v] = matrix[v, i];
                }

            }

            return transpMatrix;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[,] tempMatrix = new int[50, 50];
            int strCount = 0;   // счетчик строк в матрице
            Console.WriteLine("Enter a matrix (00 to exit)");
            string tempString;  // строка введенная пользователем
            string[] trueString;    // массив элементов каждой строки
            int standardColum = 0; // кол - во элементов в первой строке  
            while (true)
            {
                tempString = Console.ReadLine();
                if (tempString == "00")
                    break;
                if (strCount > 50)
                    break;
                trueString = tempString.Split(' '); // Получаем массив нужных элементов из строки 
                if (strCount == 0) // задаём кол - во колонок матрицы (по первой строчке  )
                {
                    standardColum = trueString.Length;
                }

                if (trueString.Length == standardColum && standardColum <= 50) // Проверка на корректность введенных последующих строчек
                {
                    for (int i = 0; i < standardColum; i++)
                    {
                        tempMatrix[strCount, i] = Convert.ToInt32(trueString[i]);
                    }

                }
                else if (standardColum > 50)
                {
                    Console.WriteLine("Too many columns");
                    break;
                }
                else
                {
                    Console.WriteLine("Impossible number of symbols");
                    continue;
                }
                strCount++;
            }
            Matrix matrix = new Matrix();
            int[,] transpMatrix = matrix.Transp(tempMatrix, strCount, standardColum);
            int counter = 0;
            Console.WriteLine("Transp matrix: ");
            foreach (int i in transpMatrix)
            {
                Console.Write(i + " ");
                counter++;
                if (counter % strCount == 0)
                    Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}