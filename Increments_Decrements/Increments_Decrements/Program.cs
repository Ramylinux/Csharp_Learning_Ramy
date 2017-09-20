using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, temp2, var1 = 5, var2 = 5, myVar3=7, myVar4 = 2;

            temp = var1++;


            Console.WriteLine($"MY Var1++ = {var1}   My Temp Variable = {temp}\n\n\n" );
            
            /* ===================================================== */

           
            temp2 = ++var2;


            Console.WriteLine($"MY ++Var1 = {var2}   My Temp Variable = {temp2}\n\n\n");


            /* ===================================================== */

            temp2 = myVar3-- / ++myVar4;
            Console.ForegroundColor=ConsoleColor.Red;

            Console.WriteLine($"Variables:\n\n  myVar3 = 7\n  myVar4 = 2 \n\nExpersion:\n\n  myVar3-- / ++myVar4 = {temp2}\n\n");


            /* ===================================================== */

            // OR

            /* ===================================================== */

            int temp11, temp12, myVar11 = 5, temp13;
            temp11 = myVar11++;

            Console.ForegroundColor = ConsoleColor.White;
            myVar11 = 5;
            temp12 = ++myVar11;
            Console.WriteLine("The value of myVar++ = temp is = {0}," +
                " While the result of ++myVar = temp is = {1}", temp11, temp12);

            myVar11 = 7;
            int myVar12 = 2;

            temp13 = myVar11-- / ++myVar12;
            
            Console.WriteLine("The result of this expression (myVar11-- / ++myVar12) is = {0}", temp13);

           


            /* ===================================================== */

            Console.ReadKey();


        }
    }
}
