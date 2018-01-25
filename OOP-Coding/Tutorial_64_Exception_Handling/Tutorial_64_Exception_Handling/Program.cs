using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_64_Exception_Handling
{
   class Program
   {
      
      static void Main(string[] args)
      {
         try
         {
            string[] myArray = { "Mohand", "Ahemd", "Ramy", "Ayman", };
         WriteLine();
         for (int i = 0; i < 41; i++)
            Write(myArray[i] + ", ");

           
      }
      catch(Exception ex)
      {
            WriteLine("\n\n" + ex.Message); // or you can use (Ex.StackTrace)
      }
         finally
         {
            WriteLine("\n App. Ends \n");
         }

         ReadKey();
      }
   }
}
