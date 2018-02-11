using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_69_Implicit_Casting
{
  abstract class Employee
   {
      //Data Fields.
      private string empName;
      private int empID;
      private float empPay;
      private int empAge;
      private string empSSN ="";


      //Constructors
      //Properties
      public virtual void DisplayEmpInfo()
      {
         Console.WriteLine($"Name , {Name}");
         Console.WriteLine($"ID , {ID}");
         Console.WriteLine($"Age , {Age}");
         Console.WriteLine($"Pay , {Pay}");
         Console.WriteLine($"SSN , {SocialSecurityNumber}");
         //Console.WriteLine($"Name , {empName}");
         //Console.WriteLine($"ID , {empID}");
         //Console.WriteLine($"Age , {empAge}");
         //Console.WriteLine($"Pay , {empPay}");
         //Console.WriteLine($"SSN , {empSSN}");

      }

      public virtual void GiveBonus(float amount)
      {
         empPay += amount;
      }


      #region Constructors
      //Default
      public Employee() { }
      //Paramertized Constructors
      public Employee(string name, int id,float pay) { }
      public Employee(string name, int age, int id, float pay, string ssn)
      {
        Name = name;
         Age = age;
         ID= id;
         Pay = pay;
         SSN = ssn;
         
      }
      #endregion
   }
}
