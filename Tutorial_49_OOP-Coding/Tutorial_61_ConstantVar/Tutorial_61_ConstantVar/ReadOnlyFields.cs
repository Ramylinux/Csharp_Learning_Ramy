using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_61_ConstantVar
{
   class ReadOnlyFields
   {
      ///Call ReadOnly Without static 
      //public readonly double pi;

      ///Create constracutor for add Value
      // public ReadOnlyFields()
      // {
      //     pi = 3.14;
      //   }
      ///End Call ReadOnly Without static
      ///
      /// 
      ///Call ReadOnly With static 
     public static readonly double pi; //Add static
      ///Create constracutor for add Value
       static ReadOnlyFields()
       {
          pi = 3.14;
         }
      ///End Call ReadOnly With static

   }
}
