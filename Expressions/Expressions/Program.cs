using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            int no_1 = -7, no_2 = 3, sum_1;
         
            int neV = +no_1; // No any Effet on number -7 for convert to +7 but if number +7 then add - to value neV= -no_1 =-7 then the resule is -7 

            sum_1 = neV + no_2;

            Console.WriteLine($"\n Sum = {sum_1}\n Nu={neV}");

            string myText1 = "I am ", myText2 = "Smart";

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"\n\n{myText1+myText2}");

            Console.WriteLine( "\n\n" + myText1 + myText2 + "\n");


            //OR

            /*=================================================================*/

            int myVar1 = 7, myVar2 = 3, temp;

            temp = myVar1 + myVar2;
            Console.WriteLine("myVar1 + myVar2 = " + "{0}", temp);

            temp = myVar1 - myVar2;
            Console.WriteLine("myVar1 - myVar2 = " + "{0}", temp);

            temp = myVar1 * myVar2;
            Console.WriteLine("myVar1 * myVar2 = " + "{0}", temp);

            temp = myVar1 / myVar2;
            Console.WriteLine("myVar1 / myVar2 = " + "{0}", temp);

            temp = myVar1 % myVar2;
            Console.WriteLine("myVar1 % myVar2 = " + "{0}", temp + "\n");
            //OR
            Console.WriteLine("myVar1 % myVar2 = {0}", temp + "\n");


            string myStr1 = "I am", myStr2 = " smart";
            Console.WriteLine("{0}", myStr1 + myStr2);

            /*=================================================================*/


            Console.ReadKey();


        }
    }
}
