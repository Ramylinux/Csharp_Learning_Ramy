using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_54_Paratial_Classes
{
   partial class EmployeesPart //partial Class 1 EmployeesPart1.cs
   {
      public string name = "Ramy Abu-Dhair";
      public string address = "Amman-Jordan";
      public string department = "I.T Departments";
      public int age = 39;
      //Partial Methods
      partial void MyAge(); // Create Partial Methods
      public EmployeesPart()
       { }





   }
}
