using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_25_Return_Values
{
    class Program
    {
        //Example form Course
        // Mininmum Vales
        static int MinValue(int[] myArray)
        {
            int minval1 = myArray[0];
            for(int i=1; i < myArray.Length; i++)
            {
                if (myArray[i]<minval1)
                    minval1 = myArray[i];
            }


            return minval1;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Question 26
        //
        static double AvarageRate(int [] arrayAvarage)
        {
            double myAvarage = arrayAvarage[0];
            double total;
            for (int i =1;i<arrayAvarage.Length;i++)
            {
                 myAvarage = myAvarage + arrayAvarage[i];
                
            }
           // Console.WriteLine($"my Avarage from this Function is {myAvarage}\n");
            total = myAvarage / 7;

            return total;
        }




        static void Main(string[] args)
        {

       //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       //Example form Course
            int[] myarray = { 10, 22, 34, 5, 6, 78, 2, 11 };
          int minVal1= MinValue(myarray);
          Console.WriteLine($"The Minimum Value in my Array is : {minVal1}");
          Console.ReadKey();

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Question 26
            //Define a function to find the avarage
            //of a student that has 7 grades and print the
            //result in the void main

            Console.WriteLine(@"//Question 26
            //Define a function to find the avarage
            //of a student that has 7 grades and print the
            //result in the void main\n\n");

            int[] arrayAvarage = {1,2,30,4,5,6,7 };

            double avarage = AvarageRate(arrayAvarage);
            Console.WriteLine($" The the avarage of a student that has 7 grades is {avarage}\n\n"); 

        }// Close ==> static void Main(string[] args)
    }
}
