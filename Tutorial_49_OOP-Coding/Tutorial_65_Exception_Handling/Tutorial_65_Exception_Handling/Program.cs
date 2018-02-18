using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_65_Exception_Handling
{
   class Program
   {
      static void Main(string[] args)
      {
         try //Multiple Catch Statements
         {
            string[] myArray = { "Mohand", "Ahemd", "Ramy", "Ayman", };
            WriteLine();
            for (int i = 0; i < 4; i++)
               Write(myArray[i] + ", ");

            WriteLine("\n\nEnter Your Number \n");
            decimal myDeci = Convert.ToDecimal(ReadLine());

            int x = 10, y = 0;
            int z = x / y;

         }
         catch (IndexOutOfRangeException ex1)
         {
            //WriteLine("\n\n" + ex1.StackTrace); 
            WriteLine("\n\n" + ex1.ToString()); // Meaning print exception (stackTrace) into (ToString)
         }
         catch (FormatException fx1)
         {
            WriteLine(fx1.Message);
         }
         catch (DivideByZeroException cx)
         {
            WriteLine(cx.Message);

         }
         catch(Exception exall) //in Genaral any Exception you unkown what is type 
         //so, used in class general exception as catch(Exception ...) then the system dectect this is exception  but this is not professional
         // you must known what is exception maybe camming
        
         {
            WriteLine(exall.ToString());

         }
         finally // more used for close connect database if not successfully connection
         {
            WriteLine("\n Hello this is App. Ends \n");
         }

         ReadKey();

      }




   }
}
