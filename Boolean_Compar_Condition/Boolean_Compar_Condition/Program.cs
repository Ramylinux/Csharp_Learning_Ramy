using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Compar_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 9, myVar2 = 11;
            bool myResult, myResult_or;

            myResult = (myVar1 < 10) && (myVar2 <= 11);
            myResult_or = (myVar1 < 10) || (myVar2 <= 11);

            Console.WriteLine($" Notes: \n myVar1 = 9 \n myVar2 = 11 \n\n Result && is = {myResult}\n\n Result || is {myResult_or}\n\n");

            /*==========================================================*/

            //int myVar1 = 9, myVar2 = 11;
            bool myConditionResult;

            myConditionResult = ((myVar1 <= 9) && (myVar2 <= 11));
            Console.WriteLine("The Result of my condition is {0}", myConditionResult);
            myConditionResult = ((myVar1 <= 9) || (myVar2 <= 11));
            Console.WriteLine("The Result of my condition is {0}\n\n", myConditionResult);

            Console.ReadKey();


        }
    }
}
