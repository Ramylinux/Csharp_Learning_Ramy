using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_63_Interface_Abstract
{
   class Program
   {
      static void Main(string[] args)
      {
         Managers myManagOb = new Managers();
         Tech_Assistant myTechOb = new Tech_Assistant();

         myManagOb.CanManage();
         myManagOb.CanPunish();
         
         myManagOb.PrintFullName();

         myTechOb.CanPunish();
         myTechOb.CanManage();

         ReadKey();
      }
   }
}
