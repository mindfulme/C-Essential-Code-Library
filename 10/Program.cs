using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you gonna do? ");
            Console.WriteLine("1-tell a little story about things on the table ");                                 
            Console.WriteLine("2-Leave the program ");
            int sentence1 = Convert.ToInt32(Console.ReadLine());
            if (sentence1 == 1)
            {
                Console.WriteLine("Make a decision");
                Console.WriteLine("1st I see the only one thing on the table_____");
                Console.WriteLine("2nd I see a cup and a spoon , a thing _____ is located _____ from the other thing _____");
                int sentence2 = Convert.ToInt32(Console.ReadLine());
                if (sentence2 == 1)
                {
                    Console.WriteLine("What are you seeing? ");
                    Console.WriteLine("1: a spoon , 2: a cup ");
                    int sentence3 = Convert.ToInt32(Console.ReadLine());
                    if (sentence3 == 1)
                        Console.WriteLine("Ok. You've implied:''I see a spoon''");
                    else if (sentence3 == 2)
                        Console.WriteLine("Ok. You've implied:''I see a cup''");
                    Console.WriteLine("What you would like to do next ");
                    Console.WriteLine("1- to see the scheme of the table");
                    Console.WriteLine("2- to leave the program");
                    int sentence4 = Convert.ToInt32(Console.ReadLine());
                    if (sentence4 == 1)
                        if (sentence3 == 1)
                            Console.WriteLine("S");
                        else if (sentence3 == 2)
                            Console.WriteLine("C");
                    if (sentence4 == 2)
                        Console.ReadKey();
                }
                else if (sentence2 == 2)
                {
                    Console.WriteLine("How is located the cup in relation to the spoon?");
                    Console.WriteLine("1-the cup is on the left side ");
                    Console.WriteLine("2-the cup is on the right side");
                    Console.WriteLine("3-a cup is ahead");
                    Console.WriteLine("4-a cup is behind");
                    int sentence3=Convert.ToInt32(Console.ReadLine());
                    if (sentence3 == 1)
                        Console.WriteLine("Ok. You've implied:''I see the cup on the left side of the spoon''");
                    else if (sentence3 == 2)
                        Console.WriteLine("Ok. Ви повiдомили:''I see the cup on the right side of the spoon''");
                    else if (sentence3 == 3)
                        Console.WriteLine("Ok. Ви повiдомили:''I see the cup ahead the spoon''");
                    else if (sentence3 == 4)
                        Console.WriteLine("Ok. Ви повiдомили:''I see the cup behind the spoon''");
                    Console.WriteLine("What you would like to do? ");
                    Console.WriteLine("1-the table's scheme");
                    Console.WriteLine("2-to leave the program");
                    int sentence4 = Convert.ToInt32(Console.ReadLine());
                    if (sentence4 == 1)
                        if (sentence3 == 1)
                            Console.WriteLine("C  L");
                        else if (sentence3 == 2)
                            Console.WriteLine("S  C ");
                        else if (sentence3 == 3)
                        {
                            Console.WriteLine("S");
                            Console.WriteLine("C");
                        }
                        else if (sentence3 == 4)
                        {
                            Console.WriteLine("C");
                            Console.WriteLine("S");
                        }
                        else if (sentence4 == 2)
                            Console.ReadKey();
                }
           }
            else if (sentence1 == 2) ;
            Console.ReadKey();
        }
    }
}
