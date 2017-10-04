using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9_Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 
            long myVar = 1000;
            float myVar2 = myVar;

            // float myfolatVar = 12.5f;
            // int myInt2Var = myfolatVar;     //Wrong, it needs an explicit conversion


            // Console.WriteLine($"{myVar2} \n\n");

            char myVar3 = 'G';
            int myIntvar = myVar3;

            Console.WriteLine($"\nConvert Variable long =\"1000 \"to float={myVar2} \nConvert Variable char= \"G\" to int={myIntvar}\n");
            Console.ReadKey();
            /*
            
            There are operation which you can convert Implicit Conversion by casting:

            // byte  -->   short, ushort, int, uint, long, ulong, float, double, decimal
            //sbyte  -->   short, int, long, float, double, decimal
            //short  -->   int, long, float, double, decimal
            //ushort -->   int, uint, long, ulong, float, double, decimal
            //int    -->   long, float, double, decimal
            //uint   -->   long, ulong, float, double, decimal
            //long   -->   float, double, decimal
            //ulong  -->   float, double, decimal
            //float  -->   double
            //char   -->   ushort, int, uint, long, ulong, float, double, decimal


*/


}






}
}
