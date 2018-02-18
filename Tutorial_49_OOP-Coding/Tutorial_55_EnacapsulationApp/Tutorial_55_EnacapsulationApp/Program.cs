using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_55_EnacapsulationApp
{
   class Program
   {
      static void Main(string[] args)
      {
         string name = "Ramy Abu-Dhair";
         int age = 39;
         Person myObj = new Person();
         myObj.SetName(name); // Send value to Private variables
         myObj.SetAge(age); // Send value to Private variables

         Console.WriteLine("Name is " + myObj.GetName()); // Get Value from Private Variables
         Console.WriteLine("Age is " + myObj.GetAge()); // Get Value from Private Variables

         Console.ReadKey();
      }
   }
}
