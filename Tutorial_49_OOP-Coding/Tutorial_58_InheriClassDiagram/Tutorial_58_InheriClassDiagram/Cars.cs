using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_58_InheriClassDiagram
{
   public class Cars
   {
      public string model="RAV4";
      public string make="Toyota";
      public int year=2009;

      public void PrintModel()
      {
         //throw new System.NotImplementedException();
         Console.WriteLine($"{model}");
      }
   }
}