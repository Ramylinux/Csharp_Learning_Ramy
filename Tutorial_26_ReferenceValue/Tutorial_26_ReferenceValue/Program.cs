using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_26_ReferenceValue
{
    class Program
    {
        //Example
        static void MultiplyNumber(ref int myVar) //Example
        {
            myVar *= 3;
            Console.WriteLine($"( Inside Function ) My Number = {myVar}\n");
        }

        //Question 27
        
        static void MultiNumbers(ref int number1,ref int number2)
        {
              number1 *= number2; //Multiply Number
              number2 += number1; // Sum
        }
        // From Tutorial Question 27

        static void DoubleNum(ref int val, ref int val2)
        {
            val *= 2;
            val2 *= 4;
            Console.WriteLine($"myNumber = {val}");
        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        static void Main(string[] args)
        {
            //Example
            int myNumber = 5;
            Console.WriteLine($"(Variable is myNumber  )  My Number = {myNumber}\n");
            MultiplyNumber(ref myNumber); // Without ref ==> MultiplyNumber(myNumber); this Value return is mynumber = 5 
            Console.WriteLine($"(Varibale My Function is) My Number = {myNumber}\n"); 
            Console.ReadKey();

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //Question 27
            Console.WriteLine (@"Q27: define a function that accept two paramerters
 as refernce Values and Change them using multiplication
 by 4 and print the result"+"\n\n");

            int number1=4,number2=3;
            Console.WriteLine($"(Without Ref ) Multiply Two  Numbers is Number1:= {number1} Number2:= {number2} \n\n ");

            MultiNumbers(ref number1,  ref number2);
         
            Console.WriteLine($" (With  Ref ) Multiply  Two  Numbers is Number1:= {number1} Number2:= {number2} ");

            //// From Tutorial Question 27
            int myNumber1 = 5, myNumber2 = 4;
            Console.WriteLine($"myNumber = {myNumber1}");
            DoubleNum(ref myNumber, ref myNumber2);
            Console.WriteLine($"myNumber = {myNumber1},{myNumber2}");
            Console.ReadKey();


        }// Close ==> static void Main(string[] args)
    }
}
