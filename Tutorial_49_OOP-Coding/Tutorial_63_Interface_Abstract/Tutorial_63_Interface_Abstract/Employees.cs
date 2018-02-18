using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_63_Interface_Abstract
{
   abstract class Employees:Departments
   {
      //Start fields and Access modifer (Public)
      public string fname;
      public string lname;
      public string address;
      public double salary;
      public int phone;
      public string startDate;
      //End fields and Access modifer (Public)

      public void PrintFullName() { WriteLine ("Full Name From Abstract Employees"); } // Full Method or gangrened Methods
      public abstract void PrintEmpSalary(); // (RunningPartial)Abstract Methods 
   }
}
