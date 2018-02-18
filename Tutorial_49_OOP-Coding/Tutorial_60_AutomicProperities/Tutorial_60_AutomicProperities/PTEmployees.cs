using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_60_AutomicProperities
{
   sealed class PTEmployees : Employees
   {
      public override void PrintName()
      {
         Console.WriteLine($"This is Name from calss PTEmployees Child : {name}");
      }
      public override void PrintDepart()
      {
         Console.WriteLine($"This is Department from calss PTEmployees Child : {department = "PTE mployees"}");
      }
      public string shift;

   }
}
