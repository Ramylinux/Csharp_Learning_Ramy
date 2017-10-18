using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_15_Array_QUESTION
{
    class Program
    {
        static void Main(string[] args)
        {
                   

            const int myArraySize = 5;
            
            int no, bigSize = 1, i = 0,ii=0,bigSizeRead=1;

            int[] insertmyNumber = new int[myArraySize]; // index Array 4 number from {0 to 4}


            int[] myNumber4 = new int[myArraySize] { 90, 15, 800, 250, 131 }; // index Array 4 number from {0 to 4}

            Console.WriteLine("\nMy numbers" + " is  " + $"{myNumber4[4]}\n");

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Console.ReadKey();



            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Tutorial_Question 22
            // Tutorial_Question 22 Define an array of int type and find the max value

            Console.WriteLine("Tutorial_Question 22 \n\nDefine an array of int type and find the max value\nArray { 90, 15, 800, 250, 131 } \n\n ");

                        Console.ReadKey();

            Console.WriteLine("Array Value is { 90, 15, 800, 250, 131 } \n\n ");

           

                        for (int j = 0; j <= 4; j++)
                        {
                            if (myNumber4[i] < myNumber4[j])
                            {
                                if (bigSize < myNumber4[j])
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    bigSize = myNumber4[j];
                                }

                            }

                            else if ((bigSize < myNumber4[i]))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                bigSize = myNumber4[i];

                            }

                        }

                        Console.WriteLine($"\n Big Number is variable j: = {bigSize}\n ");

                        Console.WriteLine("\n\n ");

                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ReadKey();

                        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                        // Tutorial_Question 22
                        // Tutorial_Question 22 Define an array of int type and find the max value By Entry Data Value

                        Console.WriteLine("Tutorial_Question 22 \n\nDefine an array of int type and find the max value By Entry Data Value \n\n ");

                        Console.ReadKey();

            //++++++++++++++++++++++++++++++++

          // Insert Numbers

            for ( int R = 0; R <= 4; R++)
            {
                Console.WriteLine("\nPlease Insert 5 numbers:\n");
                no = Convert.ToInt32(Console.ReadLine());
                insertmyNumber[R] = no;
                
            }
           
            Console.WriteLine($"\n Big Number is variable R (2): = {insertmyNumber[2]}\n ");

            Console.WriteLine("\n\n ");

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // compare  Big Numbers

            for (int j = 0; j <= 4; j++)
            {
                if (insertmyNumber[ii] < insertmyNumber[j])
                {
                    if (bigSizeRead < insertmyNumber[j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        bigSizeRead = insertmyNumber[j];
                    }

                }

                else if ((bigSizeRead < insertmyNumber[ii]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    bigSizeRead = insertmyNumber[ii];

                }

            }

            Console.WriteLine($"\n Big Number is variable j: = {bigSizeRead}\n ");

            Console.WriteLine("\n\n ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            //++

        }

    }
}
