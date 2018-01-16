using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_62_Virtual_VS_Sealed
{
   class Financial:Employees
   {
      string name;
      double salary;
      public override void PrintName()
      {
         //base.PrintSalary();
         Console.WriteLine(name="Name From Financial");
      }
      public sealed override void PrintSalary()
      {
         //base.PrintSalary();
         Console.WriteLine(salary=900);
      }


   }
}
