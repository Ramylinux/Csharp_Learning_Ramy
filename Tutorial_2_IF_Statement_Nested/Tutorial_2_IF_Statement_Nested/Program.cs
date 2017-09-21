using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2_IF_Statement_Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 12, myVar2 = 6, myVar3 = 8;
    //Q1
            bool myResult =(myVar2 >= 5)&&(myVar3 <= 9);

            if (myVar1 == 10)
            {
                if (myResult)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n\n Successfully is Condition Completed \n\n\n Thank you \n\n\n");

                }
                else
                {
                    Console.WriteLine($"\n\n Sorry is Condition not Completed \n\n\n Thank you \n\n\n");
                }

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"\n\n Error is Condition Wrong \n\n\n Thank you \n\n\n");
                
            }


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.ReadKey();
/*==================================================================================================*/

// Q2 --- Another (Nested if statments)

           // int myVar1 = 10, myVar2 = 6, myVar3 = 8;
            if (myVar1 == 10)
            {
                Console.WriteLine("My variable equal 10");
            }
            else
            {
                Console.WriteLine("My Variable is not equal 10");
            }
            if ((myVar2 >= 5) && (myVar3 <= 9))
            {
                Console.WriteLine("My Variable 2 is >= 5 and my Variable 3 is <=9");
            }
            else
            {
                Console.WriteLine("My variables didn't match the conditions");
            }

            Console.ReadKey();
/*==================================================================================================*/

   // Q3 --- Another (Nested if statments)

            Console.ForegroundColor = ConsoleColor.White;

            // int myVar1 = 10, myVar2 = 6, myVar3 = 8;
            if (myVar1<=4)
            {
                Console.WriteLine("\n\n\n\nCondition one Right\n\n\n");
            }
            else if (myVar1 >= 4 && myVar2 >= 7)
            {
                Console.WriteLine("\n\n\n\nCondition Two Right\n\n\n");

            }
            else if (myVar3 >5)
            {
                Console.WriteLine("\n\n\n\nCondition Three Right\n\n\n");
            }
            else
            {
                Console.WriteLine("\n\n\n\nNo one if the Conditions\n\n\n");
            }
  /*==================================================================================================*/

            Console.ReadKey();

        }
    }
}
