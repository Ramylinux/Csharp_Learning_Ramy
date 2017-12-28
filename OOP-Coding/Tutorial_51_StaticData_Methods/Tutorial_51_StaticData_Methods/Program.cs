using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_51_StaticData_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticData_Methods s1 = new StaticData_Methods(50); //Add the Value To public double currBalance
            StaticData_Methods s2 = new StaticData_Methods(100); //Add the Value To public double currBalance
            //---------------------------------------------------------------
            Console.WriteLine("CurrBalance S1 is: {0}",s1.currBalance );
            Console.WriteLine("CurrBalance S2 is: {0}", s2.currBalance);
            //---------------------------------------------------------------
            Console.WriteLine("\n");

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is static constructor : {0}", StaticData_Methods.GetValue()); //Call Class StaticData_Methods

           StaticData_Methods.SetInterestRate(0.7);

            //Even If we make new object, this does NOT ’reset’ the interest rate.
            StaticData_Methods s3 = new StaticData_Methods(2000);

            //---------------------------------------------------------------
            Console.WriteLine("CurrBalance S3 is: {0}", s3.currBalance);
            Console.WriteLine("\n");
            //---------------------------------------------------------------

            Console.WriteLine("Interest Rate is: {0}", StaticData_Methods.GetValue());
            Console.ReadLine();

        }
    }
}
