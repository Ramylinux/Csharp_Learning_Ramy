using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_28_Variables_Scope
{
    class Program
    {
        static string myString; //Global Variables
        static void printMyString ()
        {
            string myString = "My String inside the printMyString Function Method"; // Local Variables inside Function
            Console.WriteLine($"\n{myString} Function Method");
            Console.WriteLine($"{Program.myString} Function Method\n");
            // you can Change Name this Variable from myString to another name (eg:myString2) and need call by Program Class 
            //Otherwise after change Name you call as myString2 eg: Console.WriteLine($"{myString2} Function Method\n");
        }
        static void Main(string[] args)
        {
            string myString= "My String inside the Main Method"; // Local Variables inside Main
            Console.WriteLine($"\n{myString}\n"); // Call  Local Variables inside Main

            Program.myString = "Global my String Variable";
            Console.WriteLine($"\n{Program.myString} Main Method \n"); // Call Global Variables inside Function

            printMyString(); // Call Local and Gloval Variables inside Function

            Console.ReadKey();
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //Notes About Variable Scope in Structure

            int i, index=0; // add value for (index variable) and this value is initial value  
            //

            for (i = 0; i < 9; i++) // i=0 this is (i variable) value is initial value 
            {
                index = i;//add value for (index variable) but this value is not initial value
                Console.WriteLine($"{index}");
            }
            Console.WriteLine($"Last index output in loop : {index}");
            Console.ReadKey();
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        }//Close ==> static void Main(string[] args)

    }
}
