using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_17_Array_of_string
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] myNumbers1 = { 1, 5, 8, 9, 7 }; // Mode 1 define the array

            //int[] myNumber2 = new int[5]; // Mode 2 define the array 
            // OR
            //int[] myNumber2 = new int[]; // Mode 2 define the array 

            //int[] myNumber3 = new int[5] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK 
            //OR 
            //int[] myNumber3 = new int[5] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK
            //OR 
            // Give variable for size array == > const int arraySize=5;
            //int[] myNumber3 = new int[arraySize] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK



            string[] myFullName = new string [] { "Ramy ", "Ibrahim ", "Abu_Dhair" }; // OR : Mode1 define Array // string[] myFullName = { "Ramy ", "Ibrahim ", "Abu_Dhair" };
            int myArraylength = myFullName.Length; // for read length Array

            foreach(string fullName in myFullName)
            {
                Console.Write($"{fullName}");
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
            //++++++++++++++++++++++++++++++++++++++++++++++++
            // oR
            //****************************************************
            Console.ForegroundColor = ConsoleColor.Green;

        for(int i=0; i < myArraylength; i++)
            {
                Console.Write($"{myFullName[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"   My Array length is : {myArraylength}");

            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

        }


        //****************************************************
    }
}
