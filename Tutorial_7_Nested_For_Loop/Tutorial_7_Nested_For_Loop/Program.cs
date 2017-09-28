using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_7_Nested_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
// Example
for(int ii = 0; ii < 3; ii++)
            {
                Console.WriteLine("Hello Ramy");
                for(int jj = 0; jj < 2; jj++)
                {
                    Console.WriteLine("\tHello World !!!");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();

            /*=============================================================*/

            // Q1 / Create Multiplication table from 1 - 5 for all numbers <= 10 
            /* Ramy Code //  

                     Console.WriteLine("\nQ1  ====================================================================");
                     int  result0=1;

                     for (int iii = 1; iii <= 5; iii ++)
                     {

                          for (int jjj = 1; jjj <= 5; jjj++)
                         {
                             result0 = iii * jjj;
                             Console.WriteLine($"\n {iii}*{jjj}={result0}");

                         }
                         Console.WriteLine("\n");

                     }
                     Console.ReadKey();

                     // =============================================================

            // Q1 / Create Multiplication table from 1 - 5 for all numbers (Result ) <= 10
            Console.WriteLine("\nQ1 result  ==============================================================");

            int result1 = 1;

            for (int nu1 = 1; nu1 <= 5; nu1++)
            {
               
                    for (int nu2 = 1; nu2 <= 5; nu2++)
                    {
                        result1 = nu1 * nu2;

                    if (result1 <= 10)
                    {
                        Console.WriteLine($"\n {nu1} * {nu2} = {result1}");

                    }
                    
                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();

    
            //=============================================================

            // Q2 / Create Multiplication table from 1 - 6 for even numbers (Result ) <= 10
            Console.WriteLine("\nQ2 Even ================================================================");

            int result2 = 1;

            for (int nu1 = 2; nu1 <= 6; nu1+=2)
            {

                for (int nu2 = 1; nu2 <= 6; nu2++)
                {
                    result2= nu1 * nu2;

                    if (result2 <= 10)
                    {
                        Console.WriteLine($"\n {nu1} * {nu2} = {result2}");

                    }

                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();
            

            // Q3 / Create Multiplication table from 1 - 6 for odd numbers (Result ) <= 10
            Console.WriteLine("\n Q3 Odd =================================================================");

            int result3 = 1;

            for (int no1 = 1; no1 <= 6; no1 += 2)
            {

                for (int no2 = 1; no2 <= 6; no2 ++)
                {
                    result3 = no1 * no2;

                    if (result3 <= 10)
                    {
                        Console.WriteLine($"\n {no1} * {no2} = {result3}");

                    }

                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();

    Ramy Code -- End */

            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 


            // OR Anothe Soluations

            Console.WriteLine("\n Anothe Soluations =================================================================");

            //Challenge 14
            //Q1 / Create Multiplication table from 1 - 5 for all numbers <=10

            Console.WriteLine(" //Q1 / Create Multiplication table from 1 - 5 for all numbers <=10\n");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "= " + " {0}\n", i * j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();




            //Q2 / Create Multiplication table from 1 - 6 for even number <=10
            Console.WriteLine(" //Q2 / Create Multiplication table from 1 - 6 for even number <=10\n");
            for (int i = 2; i <= 6; i += 2)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "= " + " {0}\n", i * j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();


            //Q3 / Create Multiplication table from 1 - 6 for odd number  <=10
            Console.WriteLine("  //Q3 / Create Multiplication table from 1 - 6 for odd number  <=10\n");
            for (int i = 1; i <= 6; i += 2)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "= " + " {0}\n", i * j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();















        }
    }
}
