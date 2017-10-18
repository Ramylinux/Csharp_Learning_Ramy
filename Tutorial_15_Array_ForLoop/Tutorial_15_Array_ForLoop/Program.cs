using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_15_Array_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial Example Array


            int[] myNumbers1 = { 1, 5, 8, 9, 7 }; // Mode 1 define the array
            int[] myNumber2 = new int[5]; // Mode 2 define the array

            int[] myNumber3 = new int[5] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK 

            // You can change size array [5] to Variable as

            const int myArraySize = 5;

            int[] myNumber4 = new int[myArraySize] { 90, 15, 800, 250, 131 }; // index Array 4 number from {0 to 4}

            Console.WriteLine("\nMy numbers" +" is  " + $"{myNumber4[4]}\n");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.ReadKey();
            
            // Printing Array by for Loop
            Console.WriteLine("\nPrinting Array by for Loop\n\n");
            for (int j=0; j < 5; j++)
            {
             // Console.WriteLine($"\nMy Numbers: {j+1} = " + $"{myNumber4[j]}\n\n");
             //OR
              Console.WriteLine($"\nMy Numbers:{j+1} = {myNumber4[j]}\n ");
            }


            Console.ReadKey();


            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Tutorial_Qestion 22
            // Tutorial_Qestion 22 Define an array of int type and find the max value

            Console.WriteLine("Tutorial_Qestion 22 \n\nDefine an array of int type and find the max value \n\n ");

            Console.ReadKey();

            int bigSize=1,i=0;

                    for (int j = 0;j<=4; j++)
                    {
                            if (myNumber4[i] < myNumber4[j]) 
                                    {
                                    if (bigSize < myNumber4[j])
                                             {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            bigSize = myNumber4[j];
                                              }
                       
                                     }

                            else if((bigSize < myNumber4[i]))
                                  {
                                 Console.ForegroundColor = ConsoleColor.Red;
                                bigSize = myNumber4[i];

                                    }
               
            }

            Console.WriteLine($"\n Big Number is variable j: = {bigSize}\n ");
                                          
            Console.WriteLine("\n\n ");

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.ReadKey();






        }



    }
}
