using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_60_AutomicProperities
{
   class HR : Employees
   {
      public override void PrintName()
      {
         Console.WriteLine($"This is Name from calss HR Child : {name}");
      }
      public override void PrintDepart()
      {
         Console.WriteLine($"This is Department from calss HR Child : {department = "HR"}");
      }
   }
}
