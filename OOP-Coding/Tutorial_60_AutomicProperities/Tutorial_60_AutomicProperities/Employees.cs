using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_60_AutomicProperities
{
   abstract class Employees //Add abstract word before class Employee
   {
      public string name;
      public string department;

      public abstract void PrintName();
      public abstract void PrintDepart();

   }
}
