using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_63_Interface_Abstract
{
 abstract  class Departments
   {
      public string departname;
      public int empNum;
      public abstract void PrintDepName(); // this is Function must be available into Class Managers because Managers Class inherit from Employees Class
      // and Employees Class inherit from Departments Class
   }
}
