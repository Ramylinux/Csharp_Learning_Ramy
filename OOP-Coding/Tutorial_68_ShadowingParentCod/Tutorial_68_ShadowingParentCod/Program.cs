using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_68_ShadowingParentCod
{
   class Program
   {
      static void Main(string[] args)
      {
         Finance myFinanObj = new Finance();
         myFinanObj.PrintName();

         //method of the parent !


         ((HumRe)myFinanObj).PrintName(); //Call Obj

         Console.ReadLine();
      }
   }
}
