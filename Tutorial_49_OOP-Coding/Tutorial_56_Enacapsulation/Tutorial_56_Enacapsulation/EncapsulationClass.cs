using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_56_Enacapsulation
{
   class EncapsulationClass
   {
      private string fname = "Ramy";
      private string mname = "Ibrahim";
      string lname = "Abu-Dhair";
      int age = 39;
      public void PrintFullName() { Console.WriteLine($"{fname}  {mname} {lname}"); }
      public void PrintAge() { Console.Write($"My Age is  {age}"); }

      public void set(string fname, string mname)
      {
         this.fname = fname;
         this.mname = mname;

      }
      public string get1()
      {
         return fname;
      }
      public string get2()
      {
         return mname;
      }


   }
}
