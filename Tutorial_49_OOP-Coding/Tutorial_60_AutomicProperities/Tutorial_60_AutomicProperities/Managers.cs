using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_60_AutomicProperities
{
   class Managers : Employees
   {
      // defualt value type with  automic propertities
      public string nameManager; // Defualt Value into automic propertities

      public override void PrintName()
      {
         Console.WriteLine($"This is Name from calss manager Child : {name}");
      }
      public override void PrintDepart()
      {
         Console.WriteLine($"This is Department from calss Managers Child : {department = "Manager"}");
      }
   }
}
