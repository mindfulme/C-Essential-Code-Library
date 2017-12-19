using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_14
{
    class Space
    {
        int[,] matrix;
        int str;
        int col;
        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public int Str { set { str = value; } }
        public int Col { set { col = value; } }
        static List<int[]> CopyList(List<int[]> OldList)
        {
            List<int[]> newList = new List<int[]>();
            foreach (var item in OldList)
            {
                newList.Add(item);
            }
            return newList;
        }
        public void CheckChainArea()
        {
            int counter = 0; 
            List<int[]> coordinates = CoordinatsOfOne(); 
            List<int[]> idOne = CopyList(coordinates); 
            FindOne(ref counter, coordinates, idOne);
            Console.WriteLine(counter);
        }
        void FindOne(ref int counter, List<int[]> coordinates, List<int[]> OneForCheck)
        {
            if (OneForCheck.Count == 0 && coordinates.Count != 0)
            {
                counter++;
            }
            else
            {
                List<int[]> NewOneForCheck = new List<int[]>();
                foreach (int[] one in OneForCheck)
                {
                    for (int j = 0; j < coordinates.Count; j++)
                    {
                        if ((Math.Abs(one[0] - coordinates[j][0]) == 1) ^ (Math.Abs(one[1] - coordinates[j][1]) == 1))
                        {
                            NewOneForCheck.Add(coordinates[j]); 
                        }
                    }
                    coordinates.Remove(one);
                    FindOne(ref counter, coordinates, NewOneForCheck);
                }
            }
        }

        List<int[]> CoordinatsOfOne()
        {
            List<int[]> coordinats = new List<int[]>();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        coordinats.Add(new int[] { i, j });
                    }
                }
            }
            return coordinats;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tempMatrix = new int[50, 50];
            int strCount = 0;  
            Console.WriteLine("Enter a matrix (000 to exit)");
            string tempString; 
            string[] trueString;    
            int standardColum = 0;  
            while (true)
            {
                tempString = Console.ReadLine();
                if (tempString == "000")
                    break;
                if (strCount > 50)
                    break;
                trueString = tempString.Split(' '); 
                if (strCount == 0) 
                {
                    standardColum = trueString.Length;
                }

                if (trueString.Length == standardColum && standardColum <= 50) 
                {
                    for (int i = 0; i < standardColum; i++)
                    {

                        tempMatrix[strCount, i] = Convert.ToInt32(trueString[i]);
                    }

                }
                else if (standardColum > 50)
                {
                    Console.WriteLine("Too many columns ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number of elements entered");
                    continue;
                }
                strCount++;
            }
            Space space = new Space();
            space.Matrix = tempMatrix;
            space.Str = strCount;
            space.Col = standardColum;
            space.CheckChainArea();
            Console.ReadKey();
        }
    }
}