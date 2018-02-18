using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_54_Paratial_Classes
{
   partial class EmployeesPart //partial Class 2 EmployeesPart2.cs
   {
      public void PrintName() { Console.WriteLine($"Name  = {name}"); }
      public void PrintAdress() { Console.WriteLine($"Adress  = {address}"); }
      //1: implantation for partial Methods 
      partial void MyAge() // implantation for partial Methods
      {
         Console.WriteLine($"Employee Age is = {age}");
      }
      //2: Call partial Method by Function  public void PrintDepartment()
      public void PrintDepartment()
      {
         Console.WriteLine($"Department  = {department}");
         MyAge(); // Call partial Method by Function  public void PrintDepartment()
      }


   }
}
