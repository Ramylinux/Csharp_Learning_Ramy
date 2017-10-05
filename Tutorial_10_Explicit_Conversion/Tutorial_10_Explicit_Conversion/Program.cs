using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_10_Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type1 = (Type1)Type2                  //Casting

            byte mySbyte;                           //0 - 255
            int myInt = 350;                        //‭000101011110‬
            // mySbyte = myInt;                    // 000011111111‬                
            mySbyte = (byte)myInt;                 // 000001011110

            Console.WriteLine($"My variable Int = {myInt}" + "\n");
            Console.WriteLine($"My byt variable  = {mySbyte}");
            Console.WriteLine("\n\n\nNext...Example 2\n\n\n");
            Console.ReadKey();

            //+++++++++++++++++++++++++++++++++++++++++++
           int myVar1 = 350;
            //byte nu1 = checked((byte)myVar1);
            byte nu1 =unchecked((byte)myVar1);
          
         Console.WriteLine($"convert int={myVar1} to byte = {nu1}");
            Console.WriteLine("\n\n\nNext...Question 1\n\n\n");
            Console.ReadKey();
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Q1 Define a decimal variable and then convert it to an integer variable using either implicit or Explicit Conversion Operations
            //and use checked keywork to through an exception of overflow type
            Console.WriteLine("\nQ1 Define a decimal variable and then convert it to an integer variable using either implicit or Explicit Conversion Operations\nand use checked keywork to through an exception of overflow type");

          
              decimal decNo = 350;
              int intNo;
              intNo = unchecked((int)decNo);
            //intNo =decNo; //ERROR into Compailer reasons  is explicit not implicit
            Console.WriteLine($"\n\n\n\nconvert decimal={decNo} to int = {intNo}");
            Console.WriteLine("\n\n\nNext...Question 2\n\n\n");
            Console.ReadKey();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++
            // another Example convert to byte
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            decimal myvar = 300;
            byte myIntVar;
            myIntVar = checked((byte)myvar);
            Console.WriteLine($"\n\n\nMy Integer variable is {myIntVar}");
            Console.ReadKey();

        }






    }
}
