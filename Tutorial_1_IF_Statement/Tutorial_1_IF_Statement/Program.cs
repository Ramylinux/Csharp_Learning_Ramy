using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1_IF_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q1
            int myVar01 = 8;

            if (myVar01 > 10)
            {
                Console.WriteLine($"Variables is Greater 10\n\n\n");
            }
            if (myVar01 < 10) // Or else
            {

                Console.WriteLine($" Variables is less 10\n\n\n");
            }
  
 /* ============================================================================================*/
 
            int myVar1 = 12, myVar2 = 5, myVar3 = 9;

 /* ============================================================================================*/

            //Q2

            bool myResult = (myVar1 <= 11) || (myVar2 == 5) && (myVar3 >= 8);

            Console.WriteLine("The condition result is {0}\n", myResult);



            myResult = (myVar1 <= 11) || (myVar2 == 6) && (myVar3 >= 8);

            Console.WriteLine("The condition result is {0}\n\n\n\n\n\n\n", myResult);


          
 /* ============================================================================================*/

            // OR


            //   int myVar1 = 10, myVar2 = 5, myVar3 = 9;

            if ((myVar1 <= 11) || ((myVar2 == 5) && (myVar3 >= 8)))
            {
                Console.WriteLine($"This Condtion is True ( myvar2 == 5) \n\n\n  ");

            }
            if ((myVar1 <= 11) || ((myVar2 == 6) && (myVar3 >= 8)))
            {
                Console.WriteLine($"This Condtion is True ( myvar2 == 6) \n\n\n");
            }
            else
            {
                Console.WriteLine($"This Condtion is False \n\n\n");
            }


        }
                  
    }
}
