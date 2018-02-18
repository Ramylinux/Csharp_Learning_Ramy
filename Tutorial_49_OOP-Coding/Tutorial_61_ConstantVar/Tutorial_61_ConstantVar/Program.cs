using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_61_ConstantVar
{
   class Program
   {
      static void Main(string[] args)
      {
         ///Call constracutor Obj by without static 
         // ReadOnlyFields myObj = new ReadOnlyFields();

         // Console.WriteLine($"{myObj.pi}");

         // Call Static ReadOnly by Class
         Console.WriteLine($"{ReadOnlyFields.pi }"); 


      }
   }
}
