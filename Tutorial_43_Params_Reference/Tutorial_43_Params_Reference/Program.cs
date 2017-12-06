using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_43_Params_Reference
{
    class Program
    {
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            if (values.Length ==0)
            return sum;

            for (int i=0;i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);

        }

        //Question 31

        static int MaxValue(params int[] myArray)
        {
            if (myArray.Length==0)
                return 0;

            int maxval1 = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxval1)
                    maxval1 = myArray[i];
            }


            return maxval1;
        }
        //--------------------------------------------------------
        
        static void Main(string[] args)
        {
            
            double average;
            //... We Can pass arguments
            average = CalculateAverage(4.0,3.2,5.7,64.22,87.2);
            WriteLine("Avarega of Date is :{0}",average);

            //.. We Can pass an avarege of doubles
            double[] data = {4.0,3.2,5.7 };
            average = CalculateAverage(data);
            WriteLine("Average of data is:{0}",average);
            

            // ... Average of 0 is 0
            WriteLine("Average of Data is : {0}",CalculateAverage());
            ReadKey();
            WriteLine("\n");
            
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Question 31

            WriteLine(@"// Question 31:
Write a Function that accept differnet number of values and 
find the greatest number Among these numbers and don't send 
any arguments and return the values ?");
            WriteLine();


            int[] myarray = { 10, 22, 34, 5, 6, 78, 2, 10 };
            int maxVal1 = MaxValue(myarray);
            WriteLine(" 10, 22, 34, 5, 6, 78, 2, 10");
            WriteLine($"The Maximum Value in my Array is : {maxVal1}\n");
            maxVal1 = MaxValue(10, 22, 304, 5, 6, 78, 2, 10);
            WriteLine(" 10, 22, 304, 5, 6, 78, 2, 10");
            WriteLine($"The Maximum Value in my Numbers is : {maxVal1}\n");

            WriteLine($"The data insert to the Function is none : {MaxValue()}\n");
            ReadKey();



        }// Colse ==> Main Function ==>static void Main(string[] args)

    }
}
