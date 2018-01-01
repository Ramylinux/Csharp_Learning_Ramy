using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_52_Nested_Class
{
   class Employees //Class 1
   {
      public string fName = "Ramy Abu-Dhair";
      public string Address = "Jordan - Amman";
      public void PrintValues() { Console.WriteLine($"Employee Name is  {fName} \n Living at {Address}"); }

      public class Departments //Class 2
      {
         public string departmentName = "I.T Administration";
         public void PrintDepartmentName() { Console.WriteLine($"Working at  {departmentName}"); }

      }

   }



}
