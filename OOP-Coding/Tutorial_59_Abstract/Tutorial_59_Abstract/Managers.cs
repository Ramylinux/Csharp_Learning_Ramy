using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_59_Abstract
{
   class Managers:Employees
   {
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
