using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_46_Recursive_Function
{
    class Program
    {
        static int MyRecursiveFunction(int myValue, ref int counter)
        {
            counter++;
            //if value = 0
            if (myValue == 0)
                return 0;
            //if value less than 10
            else if (myValue < 10)
            {
                return MyRecursiveFunction(myValue + 1, ref counter);

            }
            //if value equal or exceeds 10
            return myValue;
        }
        //--------------------------------------------------
        //Challenge 32 
        static int FactorialCalcu(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalcu(n1 - 1);
        }
        //--------------------------------------------------
        static void Main(string[] args)
        {
            int counter = 0, myResult;
            myResult = MyRecursiveFunction(4, ref counter);
            Console.WriteLine($"My Result is {myResult} and Counter value is {counter}");
            Console.ReadKey();


            //Challenge 32 
            // Find Factorial the number n where n =5;

            int fact = FactorialCalcu(5);
            Console.WriteLine($" The factorial of 5 is : {fact}\n");


        }//Colse ==> Main Function ==>static void Main(string[] args)

    }
}
