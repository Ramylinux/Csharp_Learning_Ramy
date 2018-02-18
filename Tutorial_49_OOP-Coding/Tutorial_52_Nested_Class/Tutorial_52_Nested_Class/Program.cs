using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_52_Nested_Class
{
   class Program
   {
      static void Main(string[] args)
      {
         Employees myEmployee = new Employees(); // Access to Class 1 but you cann't access to class 2
         myEmployee.PrintValues();

         Employees.Departments myDepart = new Employees.Departments(); // Access to Class 2
         myDepart.PrintDepartmentName();
         Console.WriteLine();
         Console.ReadKey();

      }




   }

 }
