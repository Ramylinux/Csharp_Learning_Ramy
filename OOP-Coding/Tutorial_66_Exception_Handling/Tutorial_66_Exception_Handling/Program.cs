using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_66_Exception_Handling
{
   class Program
   {
      public static void Salary()
      { 
      decimal var1, var2, salary;
         try
         {
            WriteLine("Enter The Total Salary Before Cut Tax\n");
      var1 = Convert.ToDecimal(ReadLine());

            WriteLine("Enter The TAX");
      var2 = Convert.ToDecimal(ReadLine());

            salary = var1* var2;
            WriteLine("Salary Values is {0}", salary);

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
   catch (Exception myEX)
   {
      WriteLine(myEX.Message);
   }
         ReadKey();
         

      }

  




   }
}
