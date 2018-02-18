using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_53_Static_Class
{
   class Program
   {
      static void Main(string[] args)
      {
         //No Need Create instance Objects for class
         // same as : Employees1 myName = new Employees1; // this is Wrong because this class is (static class )


         Employees1.PrintName(); // Call (static class) direct
         Console.ReadKey();
      }




   }
}
