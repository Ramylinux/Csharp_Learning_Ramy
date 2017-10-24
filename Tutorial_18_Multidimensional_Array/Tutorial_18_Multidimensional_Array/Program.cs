using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_18_Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTes

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Basic Define an Array

            //int[] myNumbers1 = { 1, 5, 8, 9, 7 }; // Mode 1 define the array

            //int[] myNumber2 = new int[5]; // Mode 2 define the array 
            // OR
            //int[] myNumber2 = new int[]; // Mode 2 define the array 

            //int[] myNumber3 = new int[5] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK 
            //OR 
            //int[] myNumber3 = new int[5] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK
            //OR 
            // Give variable for size array == > 
            //const int arraySize=5;
            //int[] myNumber3 = new int[arraySize] { 1, 5, 8, 9, 7 };// Mode 3 define the array it is OK

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*
                        // define Array 2D
                        int[,] myNumbwer_2D = new int[,]
                        {
                            {1,2,3,4 },
                            {2,3,4,5 },
                            {3,4,5,6 }
                        };

                        // define Array 3D

                        int[, ,] myNumbwer_3D = new int[2,2 ,3]
                        {
                            {

                            {1,2,3 }, {4,5,6 }

                            }, 


                            {
                                {7,8,9 }, {10,11,12 }
                            }

                        };
      //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            */
            //-----------------------
            // Example 

            // define Array 2D
            int[,] myNumbwer_2D = new int[,]
            {
                            {10,20,30,40 }, // Index for Array 2D is:row 0: {0,1,2,3}
                            {22,33,44,55 }, // Index for Array 2D is:row 1: {0,1,2,3}
                            {31,41,51,61 }  // Index for Array 2D is:row 2: {0,1,2,3}
            };
        //    foreach (int item in myNumbwer_2D)
          //      Console.Write($" {item} ");
          for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write($"{myNumbwer_2D[i, j]} ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine($"\n\nIndex Numbwer 2D [2,1] Value is :{myNumbwer_2D[2, 1]} ");
            Console.WriteLine("\n\n ");
            Console.ReadKey();
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Example 2

            // define Array 3D

           
         
            int[,,] myNumbwer_3D = new int[ , , ]
            // OR
            // int[,,] myNumbwer_3D = new int[3, 2, 3] 
            {
                            {
                    // Index for Array 3D is:Group demination1 is 0: {0,1,2,3},{0,1,2,3},
                            {10,20,30 }, // Index for Array 3D is:row 0: {(0,0,0),(0,0,1),(0,0,2)}
                            {40,50,60 }  // Index for Array 3D is:row 1: {(0,1,0),(0,1,1),(0,1,2)}

                            },

                    // Index for Array 3D is:Group demination1 is 1: {0,1,2,3},{0,1,2,3},
                            {
                                {70,80,90 },// Index for Array 3D is:row 0: {(1,0,0),(1,0,1),(1,0,2)}
                                {11,12,13 } // Index for Array 3D is:row 1: {(1,1,0),(1,1,1),(1,1,2)}
                            },

                   // Index for Array 3D is:Group demination1 is 2: {0,1,2,3},{0,1,2,3},
                            {
                                {79,88,79 },// Index for Array 3D is:row 1: {(2,0,0),(2,0,1),(2,0,2)}
                                {19,62,93 } // Index for Array 3D is:row 1: {(2,1,0),(2,1,1),(2,1,2)}
                            },



            };

           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   for (int x=0; x < 3; x++)
                    {
                        Console.Write($" {myNumbwer_3D[i, j, x]}");
                    }
                  Console.WriteLine("   ");
                }
                Console.WriteLine("\n");
            }
           Console.WriteLine($"\n\nIndex Numbwer 3D [2,0,1] Value is : {myNumbwer_3D[2,0,1]} ");
            Console.WriteLine("\n\n ");
            Console.ReadKey();





            //---------------------------------  
        }

        //********************************
    }
}
