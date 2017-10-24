using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_19_Jagged_Arrays
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
           
                        // define Array 2D
                       
                        int[,] myNumbwer_2D = new int[,]
                        {
                                        {10,20,30,40 }, // Index for Array 2D is:row 0: {0,1,2,3}
                                        {22,33,44,55 }, // Index for Array 2D is:row 1: {0,1,2,3}
                                        {31,41,51,61 }  // Index for Array 2D is:row 2: {0,1,2,3}
                        };

                        // define Array 3D


                        int[,,] myNumbwer_3D = new int[,,]
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

           
            //Jagge Arrays //OR// Array of Array

            //Declare the array of two elements:
            int[][] arr = new int[2][];

            //Initialize the elements :
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 }; ;

            Console.WriteLine("\narr[0] = new int[5] { 1, 3, 5, 7, 9 };\narr[1] = new int[4] { 2, 4, 6, 8 }; \n\n");


            //Display the array elements :
            for ( int i=0; i < arr.Length; i++) // Loop on length to arr[] is Two array size (arr [2][])
            {
                Console.Write("Element ({0}):", i); // OR Console.Write($"Element({i}):");

                 for(int j = 0; j < arr[i].Length; j++) // Loop on length to arr[0] after finish loop  on length to arr[1] 
                {
                       //Console.Write(arr[i] [j]+" "); // OR Console.Write("{0}",arr[i] [j]+" ");  // OR  Console.Write($" {arr[i][j] }"+ " ");
                       // Console.Write("{0}", arr[i][j] + " ");
                       Console.Write($" {arr[i][j]}"+ " ");
                   } 
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
            Console.ReadKey();

            //Example 

            //Q24/ define a jagged array that contains these arraies inside of it
            // a = { 1,5,8,9,6.4,9}
            // b = { 0,4,3,}
            // c = { 2,9,3,10} 
            // and print the result for each arry in a seperate row

            // Question 24
            Console.WriteLine(" //Q24/ define a jagged array that contains these arraies inside of it \n a = { 1,5,8,9,6.4,9}\n b = { 0,4,3,} \n c = { 2,9,3,10} \n\n and print the result for each arry in a seperate row\n\n");
            
            double[][] arr1 = new double[3][];
            arr1[0] = new double[] { 1, 5, 8, 9, 6.4, 9 };
            arr1[1] = new double[] { 0, 4, 3 };
            arr1[2] = new double[] { 2, 9, 3, 10 };

            for (int i = 0; i < arr1.Length; i++) // loop Three once 
            {
                 Console.Write($"Element ({i}) :");

              for(int a = 0; a < arr1[i].Length; a++)
                {
                    Console.Write($"{arr1[i][a]} ");
                }

                Console.WriteLine();
            }
            
        

            Console.WriteLine();


            Console.ReadKey();

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        } // Close ==> static void Main(string[] args)


        //------------------------
    }
}
