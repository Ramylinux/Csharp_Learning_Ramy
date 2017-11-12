using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_30_Struct_Functions
{
    class Program
    {
        struct FullName
        {
           public string myFirstName, myLastName; // This Better for call Function into Structure
          
            public string printName()=> myFirstName + " " + myLastName; // This is creating print function

        }
        static void Main(string[] args)
        {
            FullName myFullName;
            myFullName.myFirstName = "Ramy";
            myFullName.myLastName = "Abu-Dhair";
            Console.WriteLine("Print function inside Main Function");
            Console.WriteLine($"{myFullName.myFirstName} {myFullName.myLastName} \n\n"); // This is call function inside Main Function

            Console.ReadKey();

            Console.WriteLine("Print function Outside Main Function");
            Console.WriteLine(myFullName.printName());// Call Print Function 



            Console.ReadKey();

        }//Colse ==> static void Main(string[] args)

    }
}
