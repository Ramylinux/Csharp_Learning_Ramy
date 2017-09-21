using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4_Ternary_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1

            int myVar1 = 2;
            string myResult;
            myResult=(myVar1>=9)?"Good Work":"bad work";
            Console.WriteLine($"this is {myResult}\n\n");
/*==============================================================================*/
            //Q2

            string myName = "Ramy AbuDhair",result;

            result = myName.Equals("Ramy AbuDhair") ? "Yes" : "No";
            Console.WriteLine($"\n\n My variable is {result}\n\n");


        }
    }
}
