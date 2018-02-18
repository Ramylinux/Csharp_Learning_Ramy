using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_57_Inheritance
{
   class Toyota:Cars
   {
      public int engineSize = 6;
      public void PrintEngineSize() { Console.WriteLine($"{engineSize}"); }

   }
}
