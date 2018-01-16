using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_60_AutomicProperities
{
   class Program
   {
      static void Main(string[] args)
      {
         
         Department myDepart = new Department();
        
         Managers myMangerOBj = new Managers();  //Define Object Type Manager
         myMangerOBj.nameManager = "Ahmed";  //Define Object Type Manager

         myDepart.departName = "Managers";
         myDepart.departEmpNumber = 12;

         myDepart.myManag = myMangerOBj;  //Define Object Type Manager

         Console.WriteLine($"{myDepart.departName} {myDepart.departEmpNumber}");
       Console.WriteLine($"{myDepart.departRoomsNumb} {myDepart.myManag.nameManager}");


         Console.ReadKey();
      }
   }
}


