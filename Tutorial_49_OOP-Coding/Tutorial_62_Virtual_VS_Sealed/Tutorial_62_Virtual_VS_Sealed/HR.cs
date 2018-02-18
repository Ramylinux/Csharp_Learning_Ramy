using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_62_Virtual_VS_Sealed
{
   class HR:Financial
   {
      string name;
      double salary;
      public override void PrintName()
      {
         //base.PrintName();
         Console.WriteLine(name="Waleed");
      }
      //public override void PrintSalary()
      //{
         
      //}

   }
}
