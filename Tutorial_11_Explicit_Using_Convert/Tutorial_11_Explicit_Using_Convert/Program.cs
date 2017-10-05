using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_11_Explicit_Using_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDoubleVar = 2500.45D;
            string myStringVar, mySubString;
            //myStringVar=myDoubleVar; // Implicit Conversion
            //myStringVar = unchecked((string)myDoubleVar); // Explicit Conversion
            myStringVar = Convert.ToString(myDoubleVar); // this is OK Convert to string
            mySubString = myStringVar.Substring(0, 3); // Print first letter ,second letter and third letter

            Console.WriteLine($"Convert My Dobule ={myDoubleVar} To My String {myStringVar}\n\n");
            Console.WriteLine($"\nPrint first letter ,second letter and third letter = {mySubString}\n ");
            Console.ReadKey();
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

         //Q1 define a float variable and assign the value 45.56f and conver it to string and print the numbers start from the float point (after .56f)
        float floatNo = 45.56f;
        string stringNo,substringNo;

            stringNo = Convert.ToString(floatNo); // 45.56F that "f" no meaning anything when to convert

            substringNo = stringNo.Substring(3); // this meaning after dot (56) but if put number 2 is meaning with dot (.56)

            Console.WriteLine($"Convert My Float ={floatNo} To My String {stringNo}\n\n");
            Console.WriteLine($"\nPrint after dot character = {substringNo}\n ");
            Console.ReadKey();


        }
        



    }
}
