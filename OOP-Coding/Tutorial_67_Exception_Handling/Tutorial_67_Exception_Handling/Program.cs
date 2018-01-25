using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_67_Exception_Handling
{
   class Program
   {
      public static void Salary()
      {
         decimal var1, tax,totaltax, salary;
         try
         {
            WriteLine("Enter The Total Salary Before Cut Tax\n");
            var1 = Convert.ToDecimal(ReadLine());
            //Start // For Create Filter Exception
            if (var1 < 501)
               throw new Exception("Salary Less than $500");
            //End // For Create Filter Exception

            WriteLine("Enter The TAX");
            tax = Convert.ToDecimal(ReadLine());

            //Start // For Create Filter Exception
            if (tax ==0)
               throw new Exception("Tax must not be a Zero");
            //End // For Create Filter Exception

            totaltax = var1 * tax;
            salary = var1 - totaltax;

            WriteLine("The Total Tax will be {0} and The Salary will be  {1}",totaltax,salary);

         }
         catch (FormatException ex1)
         {
            throw new Exception("Salary Format or Tax is not match, Try again later", ex1.InnerException);

         }
      }

      static void Main(string[] args)
      {
         try
         {

            Salary();
         }
         catch (Exception myEX) when (myEX.Message.Equals("Salary Less than $500"))  //Add (When) Word and Copy statement ("Salary Less than $500") into throw exception // For Create Filter Exception
         {
            //WriteLine(myEX.Message);
            WriteLine("This Salary has no taxes");
         }

        

         catch (Exception myEX) when (myEX.Message.Equals("Tax must not be a Zero"))  //Add (When) Word and Copy statement ("Tax must not be a Zero") into throw exception // For Create Filter Exception
         {
            //WriteLine(myEX.Message);
            WriteLine("You Entered a Zero Value for tax");
         }


         //Start // For Create Filter Exception
         catch (Exception myEX)
         {
            WriteLine(myEX.Message);
         }
         //End // For Create Filter Exception


         ReadKey();


      }






   }
}

