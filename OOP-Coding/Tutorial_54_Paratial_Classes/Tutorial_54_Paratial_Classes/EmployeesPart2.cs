using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_54_Paratial_Classes
{
   partial class EmployeesPart
   {
      public void PrintName() { Console.WriteLine($"Name  = {name}"); }
      public void PrintAdress() { Console.WriteLine($"Adress  = {address}"); }
      public void PrintDepartment() { Console.WriteLine($"Department  = {department}"); }

   }
}
