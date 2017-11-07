using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static int MinVlue(int[] myArray2, out int myIndex)
        {
            int minVal = myArray2[0];
            myIndex = 0;
            for (int i = 1; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                {
                    minVal = myArray2[i];
                    myIndex = i;
                }

            }

            return minVal;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 11, 10, 43, 6, 22, 8, 9, 13, 50, 23 };
            int myIndex; // out parameter No need value for varabiles as: int myindex=Value; just varabiles need as:  int myIndex; inside Main Program;
                         // otherwise ref paramter need Value for varabiles

            int minVal = MinVlue(myArray, out myIndex);
            Console.WriteLine($"Mimimume Vale = {minVal} and myIndex = {myIndex}");
            Console.ReadKey();



        }// Close ==> static void Main(string[] args)
    }
}
