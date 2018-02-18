using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_54_Paratial_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         EmployeesPart myEmployee = new EmployeesPart();
         myEmployee.PrintName();
         myEmployee.PrintAdress();
         myEmployee.PrintDepartment();
         Console.ReadKey();

      }


   }
}
