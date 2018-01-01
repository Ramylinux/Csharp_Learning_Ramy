using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_53_Static_Class
{
   static class Employees1 //add static to class
   {
      static public string name = "Ramy Abu-Dhair\n"; //add static to Variables ( static data)
      static public int age = 39; //add static to Variables ( static data)

      static public void PrintName() //add static to Methods ( static Methods) // and add (void) for no return any value
      {
         Console.WriteLine($"{"Name = " + name}{"AGe = " + age}");
      }
   }



}
