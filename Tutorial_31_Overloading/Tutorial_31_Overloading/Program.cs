using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_31_Overloading
{
    class Program
    {
        public static int printNumber(int myNumber)
        {

            return myNumber;
        }
        public static double printNumber(double myNumber)
        {
            return myNumber;
        }
        static void Main(string[] args)
        {
            int myNumber = 9;
            Console.Write($"{printNumber(myNumber)}");
            Console.ReadKey();

            //Q29
            //Define two functions using overloading concepts to return the minimum value of an 
            //array with 10 numbers once as integer and once as double value and print the result

        }//Colse==> static void Main(string[] args)

    }
}
