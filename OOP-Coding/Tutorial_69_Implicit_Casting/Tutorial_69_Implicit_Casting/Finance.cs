using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_69_Implicit_Casting
{
   sealed class Finance:HumanRes
   {
      public Finance(string fullName,int age, int empID,float currPay,string ssn,int numbOfSales):base(fullName,age,empID,currPay,ssn,numbOfSales)
      {

      }
      //Assume Other members here ....
   }
}
