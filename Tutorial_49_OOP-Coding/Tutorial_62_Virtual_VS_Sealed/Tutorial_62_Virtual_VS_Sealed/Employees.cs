using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_62_Virtual_VS_Sealed
{
   class Employees
   {
      string name;
      string address;
      double avgSalary;
      public virtual void PrintName() { Console.WriteLine(name="Ramy"); }
      public virtual void PrintAddress() { Console.WriteLine(address = "Amman - Jordan"); }
      public virtual void PrintSalary() { Console.WriteLine(avgSalary = 2000.50); }
      
   }
}
