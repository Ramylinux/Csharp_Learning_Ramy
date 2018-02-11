using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_69_Implicit_Casting
{
   class HumanRes : Employee
   {
      #region Constructors
      public HumanRes() { }
      // As a general rule , all subclasses should explicitly call an appropriate
      //base class Constructore.
      public HumanRes(string fullName, int age, int empID, float currPay, string ssn, int numbOfEmp) : base(fullName, age, empID, currPay, ssn)
      {
         //Human Resources class field !
         EmpNumber = numbOfEmp;
      }

      #endregion

      public int EmpNumber { get; set;}
      // A sales person's  bonus is influenced by the number of sales.
      public override sealed void GiveBonus(float amount)
      {
         int EmpBouns = 0;
         if (EmpNumber >= 0 && EmpNumber <= 100)
            EmpBouns = 10;
         else
         {
            if (EmpNumber >= 101 && EmpNumber <= 200)
               EmpBouns = 15;
            else
               EmpBouns = 20;
         }
         base.GiveBonus(amount * EmpBouns);
      }
      public override void DisplayEmpInfo()
      {
         base.DisplayEmpInfo();
         Console.WriteLine($"Number of Employees {EmpNumber}");
      }

   }
}
