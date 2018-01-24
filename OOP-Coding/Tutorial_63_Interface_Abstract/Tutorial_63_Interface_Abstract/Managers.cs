using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_63_Interface_Abstract
{
   class Managers:Employees,IManage,IPunish
   {
      //  public void PrintFullName() { WriteLine("Full Name From Managers Child Class"); } //This Complier will warning
      //because this Function available same as Employees class otherwise implementation  this fucntion here execute but into Employees Class not execute 
      public override void PrintEmpSalary() // this Function available this  employees class 
      {
         WriteLine("Salary From Managers Child Class");
      }
      public void CanManage() { WriteLine("Manage From Managers Child Class"); }
      public void CanPunish() { WriteLine("Punish From Managers Child Class"); }

      public override void PrintDepName() //Please Read Notes Into Departments Class
      {
         WriteLine("Departments Class");
      }


   }
}
