using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVar = -100;
            uint myUVar = 1000U;
            ulong myLVar = 1000u; // Or you can use character ==> UL OR u OR l
            float myFloat = 1.5f; // you must use Character is F or f
            double myDVar = 1005.65d; // Better use Character is D or d
            decimal myDecVar = 500.5M; // you must use Character is M Or m 



            Console.WriteLine("{0} {1} {2}\n", myVar,myUVar,myLVar);
            
            Console.WriteLine($"\n MYDouble= {myDVar}, MyDecimal= {myDecVar}, MyFloat= {myFloat}\n");

        }
    }
}
