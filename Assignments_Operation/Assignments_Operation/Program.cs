using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int  myVar1 = 7, myVar3 = 7,myVar2 = 2;

            myVar1 /= ++myVar2;

            Console.WriteLine($"\n\n myVar1={myVar3} / = ++myVar2=++{myVar2} is result var1={myVar1} Var2={myVar2}\n");



        //OR 

            Console.WriteLine("The result of the expression above is {0}", myVar1);

        
            Console.ReadKey();



        }
    }
}
