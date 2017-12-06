using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_44_System_Array_Function
{
    class Program
    {
        //---------------------
        static void systemArraFunctionlity()
        {
            WriteLine("Working with the Class System.Array.");
            //Initialize items at startup.
            int[] myNumbers = new[] { 11, 2, 31, 14, 5 };
            // Array Rank ...
            WriteLine($"The Rank of array = {myNumbers.Rank}");

            //Print out numbers in declared order
            WriteLine("Here is the array:");
            for (int i=myNumbers.GetLowerBound(0);i<=myNumbers.GetUpperBound(0); i++)
            {
                //Print a Number
                Write(myNumbers[i]+" ");
            }
            WriteLine("\n");
            //Sort Them ...
            Array.Sort(myNumbers);
            WriteLine("\nThe Sorted array =");
            // and Print Them
            for (int i=0;i<myNumbers.Length;i++)
            {
                Write(myNumbers[i] + "\n");
            }
            WriteLine("\n");
            //Reverse Them ...
            Array.Reverse(myNumbers);
            WriteLine("The Reversed Array = ");
            // And Print a number
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Write(myNumbers[i] + "\n");
            }
            WriteLine("\n");
          
            // Convert to another array type
            string[] array2 = Array.ConvertAll(myNumbers, element => element.ToString());
            //Write String Array
            WriteLine(string.Join(";", array2));
            WriteLine("\n");

            //Clear out all but the Final mmber
            WriteLine("Cleared out all but ...");
           // Array.Clear(myNumbers,0,myNumbers.Length);
            //OR
            Array.Clear(myNumbers,1,3);

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Write(myNumbers[i] + "\n");
            }
            WriteLine("\n");

           
            
        }//Close == > systemArraFunctionlity()

        //---------------------

        static int MaxValue(params int[] myArray)
        {
            if (myArray.Length == 0)
                return 0;

            int maxval1 = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxval1)
                    maxval1 = myArray[i];
            }


            return maxval1;
        }
        static void Main(string[] args)
        {
            int[] myarray = { 10, 22, 34, 5, 6, 78, 2, 10 };
            int maxVal1 = MaxValue(myarray);
            WriteLine(" 10, 22, 34, 5, 6, 78, 2, 10");
            WriteLine($"The Maximum Value in my Array is : {maxVal1}\n");
            maxVal1 = MaxValue(10, 22, 304, 5, 6, 78, 2, 10);
            WriteLine(" 10, 22, 304, 5, 6, 78, 2, 10");
            WriteLine($"The Maximum Value in my Numbers is : {maxVal1}\n");

            WriteLine($"The data insert to the Function is none : {MaxValue()}\n");
            ReadKey();


            //Operation on Array Class

            systemArraFunctionlity();
            ReadKey();




        }//Close ==> Main Function  static void Main(string[] args)


    }
}
