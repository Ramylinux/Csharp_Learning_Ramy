using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_24_F_ParameterVSArguments
{
    class Program
    {
        static void addNumbers(int Number1,int Number2)
        {
            int tmp = Number1 + Number2;
            Console.WriteLine($"Sum Numbers 1 = {tmp}");
        }

        static int addNumbers2(int Number1, int Number2)
        {
            int tmp = Number1 + Number2;
            return tmp;
        }


        static void Main(string[] args)
        {
            int myVar1 = 3, myVar2 = 5,tmp;
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            addNumbers(myVar1,myVar2);
            Console.ReadKey();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++
             tmp=addNumbers2(myVar1, myVar2); // You can change name virable "tmp" to another name (No problem)
            Console.WriteLine($"\n\nTotal function Add NUmber 2 = {tmp}\n\n");

            // OR // No Need Vairable name tmp: you can call function direct
            // addNumbers2(myVar1, myVar2);
            // Console.WriteLine($"\n\nTotal function Add NUmber 2 = {addNumbers2(myVar1, myVar2)}\n\n");

        
            Console.ReadKey();
        }//Colse ==> static viod Main(string[] args)


    }
}
