using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_57_Inheritance
{
   class Program
   {
      static void Main(string[] args)
      {
         Toyota myObj = new Toyota(); // from Child class
         myObj.make = "Ford"; //Change Value
                            
         int year = 2016;
       
         myObj.PrintModel(); //Read from Cars Class
         myObj.PrintEngineSize(); //Read From Toyota Class

         myObj.setYear(year); //Set Value For Variables Years=2016

         Console.WriteLine($"{myObj.make}");

         //Print  Private Variables
         Console.WriteLine($"Get Years from Private Variables : { myObj.getyear()}");

         Console.ReadKey();


      }
   }
}
