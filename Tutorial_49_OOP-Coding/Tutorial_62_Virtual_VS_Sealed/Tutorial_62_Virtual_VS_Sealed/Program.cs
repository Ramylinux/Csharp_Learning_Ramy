using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_62_Virtual_VS_Sealed
{
   class Program
   {
      static void Main(string[] args)
      {
         Employees myEmpObj = new Employees();
         Financial myFinanObj = new Financial();
         HR myHRObj = new HR();

         myEmpObj.PrintName();

         myFinanObj.PrintSalary();
         myFinanObj.PrintAddress();
         // myFinanObj.PrintName();

         myHRObj.PrintSalary();

         Console.ReadKey();


         
      }
   }
}
