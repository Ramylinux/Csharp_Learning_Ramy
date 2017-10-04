using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8_Break_loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Example ( break )
            for (int testnu1=0; testnu1 <= 5; testnu1++)
            {
                Console.WriteLine("Hello Ramy");
                if (testnu1 > 2)
                    break;
                for(int testnu2=0;testnu2 <= 4; testnu2++ )
                {
                    Console.WriteLine("\t Hello World ==> Break");
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
  //=============================================================================================================

      //Q1= (used break)Create Multiplication table  for number in the range 1 - 10 and stop the loop in the multiplication  table for number 7 from 1 - 10


            for (int nu1=1;nu1 <=10; nu1++)
            {
                Console.WriteLine(" Multiplication for Number {0}",nu1);
                if (nu1 >= 7)
                    break;
                for (int nu2=1; nu2 <= 10; nu2++)
                {
                    int result_1 = nu1 * nu2;
                    Console.WriteLine($" {nu1} * {nu2} = {result_1} ;Break");
                }
                Console.ReadKey();
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n\n\n");
            // ++++++++++++++++++++++++++++++++++++
            //
            //Example ( Continue )

            for (int testnu1 = 0; testnu1 <= 5; testnu1++)
            {
                Console.WriteLine("Hello Ramy");
                if (testnu1 > 2)
                { 
                Console.WriteLine($"{testnu1} > 2");
                continue;
                }
                    
                    for (int testnu2 = 0; testnu2 <= 4; testnu2++)
                    {
                        Console.WriteLine("\t Hello World ==> Continue");
                    }
                
                Console.WriteLine("\n");
            }

            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            //Q1= (used Continue )Create Multiplication table  for number in the range 1 - 10 and stop the loop in the multiplication  table for number 7 from 1 - 10


            for (int nu1 = 1; nu1 <= 10; nu1++)
            {
                Console.WriteLine(" Multiplication for Number {0}", nu1);
                if (nu1 >= 7)
                {
                    Console.WriteLine($"this number is {nu1} > 7");

                    continue;
                }
                for (int nu2 = 1; nu2 <= 10; nu2++)
                {
                    int result_1 = nu1 * nu2;
                    Console.WriteLine($" {nu1} * {nu2} = {result_1} ; continue");
                }
                Console.ReadKey();
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n\n\n");
            // ++++++++++++++++++++++++++++++++++++





        }
    }
}
