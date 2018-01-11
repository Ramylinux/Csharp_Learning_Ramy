using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_59_Abstract
{
   class Program
   {
      static void Main(string[] args)
      {
         Managers myMang = new Managers();
         HR myHR = new HR();
         myMang.name = "Ramy Abu-Dhair";
         myHR.name="Ahmed";

         myMang.PrintName();
         myMang.PrintDepart();

         myHR.PrintName();
         myHR.PrintDepart();
         Console.ReadKey();
      }
   }
}
