using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Add By Ramy //Now need put Console beacuse call  using static System.Console; 
using System.Diagnostics; //Add By Ramy

namespace Tutorial_33_Debugging_Methods
{
    class Program
    {
        public static int addFunction(int x, int y)
        {
            Debug.WriteLine("We started here in the Add function");

            int z = x + y;

            Debug.WriteLine("We are done here in the Add function");
            Trace.WriteLine("Enter your name as text");

            return z;

        }
        public static int mulFunction(int x, int y)
        {
            Debug.WriteLine("We started here in the Mult function");

            int z = x * y;

            Debug.WriteLine("We are done here in the Mult function");
            return z;

        }
        public static void writeFunction(int z)
        {
            Debug.WriteLine("We started here in the write function");
            WriteLine($"{z}");
            Debug.WriteLine("We are done here in the write function");
        }
        static void Main(string[] args)
        {
            int myNum, myVar1 = 4, myVar2 = 7;

            myNum = addFunction(myVar1, myVar2);
            writeFunction(myNum);
            myNum = mulFunction(myVar1, myVar2);
            writeFunction(myNum);
            ReadKey(); //Now need put Console beacuse call  using static System.Console; //Add By Ramy

        }//Colse ==> static void Main(string[] args)

    }
}
