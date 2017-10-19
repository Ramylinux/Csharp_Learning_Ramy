using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_16_Array_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example
            const int myArray = 5;
            int[] myNumber1 = new int[myArray] { 1, 15, 4, 88, 9 };
            //Question 23
            const int arraySize15 = 15; 
            int[] myNumber15 = new int[arraySize15] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            //Example
            foreach (int item1 in myNumber1)
            {
                //Console.WriteLine($"My Numbers is = {item1}");
                Console.Write("{ " + $"{item1}"+" }" );
                
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Question 23
            // Define an array of 15 elements and use foreach to iterate 14 elements only
            Console.WriteLine("\n\nDefine an array of 15 elements and use foreach to iterate 14 elements only\n\n");
            int maxNo = 14;
            //Question 23
            foreach(int limitNo in myNumber15)
            {
                if (limitNo > maxNo)
                {
                    break;
                 //   Console.Write("{ " + $"{limitNo}" + " }");
                }
                Console.Write("{ " + $"{limitNo}" + " }");
                //break;
            }

            Console.WriteLine("\n");
            Console.ReadKey();

            //**********************

        }

    }
}
