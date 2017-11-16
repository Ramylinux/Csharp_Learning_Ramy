using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Add By Ramy //Now need put Console beacuse call  using static System.Console; 
using System.Diagnostics; //Add By Ramy

namespace Tutorial_35_Assertion_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Enter a Value");
            int i = Convert.ToInt32(ReadLine()); //Casting
            if (i >= 100)
           
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We are Here");
                Debug.Assert(i >= 100, "Short", "Long"); //assert function 
                //OR           
                Trace.Assert(i >= 100, "Short", "Long");

            }
            WriteLine("Done ");



            ReadKey(); //Now need put Console beacuse call  using static System.Console; //Add By Ramy

        }//Colse ==> static void Main(string[] args)
    }
}
