using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Testing
{
    class Program
    {
        //static int MaxNumber(params int[] myNumber4)
        //{

        //    int bigSize = 1, i = 0;

        //    //  if (myNumber4.Length == 0)
        //    //     return 0;


        //    WriteLine("Array Value is { 90, 15, 800, 250, 131 } \n\n ");

        //    for (int j = 0; j <= myNumber4.Length; j++)
        //    {
        //        if (myNumber4[i] < myNumber4[j])
        //        {
        //            if (bigSize < myNumber4[j])
        //            {
        //                //  ForegroundColor = ConsoleColor.Green;
        //                bigSize = myNumber4[j];
        //            }

        //        }

        //        else if ((bigSize < myNumber4[i]))
        //        {
        //            //     ForegroundColor = ConsoleColor.Red;
        //            bigSize = myNumber4[i];

        //        }

        //    }

        //    //    WriteLine($"\n Big Number is variable j: = {bigSize}\n ");

        //    //ForegroundColor = ConsoleColor.White;
        //    //  return myNumber4;
        //    return bigSize;

        //}
        static void Main(string[] args)
        {

               int bigSize = 1, i = 0;
            int[] myNumber4 = new int [5]{ 90, 15, 800, 250, 131 };

       
            WriteLine("Array Value is { 90, 15, 800, 250, 131 } \n\n ");

            for (int j = 0; j <= myNumber4.Length; j++)
            {
                if (myNumber4[i] < myNumber4[j])
                {
                    if (bigSize < myNumber4[j])
                    {
                        //  ForegroundColor = ConsoleColor.Green;
                        bigSize = myNumber4[j];
                    }

                }

                else if ((bigSize < myNumber4[i]))
                {
                    //     ForegroundColor = ConsoleColor.Red;
                    bigSize = myNumber4[i];

                }

            }

                WriteLine($"\n Big Number is variable j: = {bigSize}\n ");

            //ForegroundColor = ConsoleColor.White;
            //  return myNumber4;
          

        


        }
    }
}
