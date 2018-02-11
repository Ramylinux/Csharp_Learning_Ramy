using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_69_Implicit_Casting
{
   class Managers:Employee
   {
      #region conatructors
      public Managers()
      {

      }
      public Managers(string fullName, int age, int empID, float currPay, string ssn, int numberOfOps ):base(fullName,age,empID,currPay,ssn)
      {
         // This  property is defined by the Managers Class.
         EmployeeNumber = numberOfOps;
      }
      #endregion
      public int EmployeeNumber { get; set; }
      public override void GiveBonus(float amount)
      {
         base.GiveBonus(amount);
         Random r = new Random();
         EmployeeNumber += r.Next(500);
      }
      public override void DisplayEmpInfo()
      {
         base.DisplayEmpInfo();
         Console.WriteLine($"Number of Employees: {EmployeeNumber}");
      }

   }
}
