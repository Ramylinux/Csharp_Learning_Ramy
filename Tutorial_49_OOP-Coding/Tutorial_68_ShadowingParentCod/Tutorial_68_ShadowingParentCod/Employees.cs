using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_68_ShadowingParentCod
{
   //The abstract base Class
  abstract class Employees
   {
      public Employees(string name="Ramy Abu-Dhair")
      {
         EmpName = name;
      }
      public string EmpName { get; set; }
      public abstract void PrintName(); //The Function have abstract so, you executive in each all classes

   }
   #region HumRe Class 

   class HumRe : Employees
   {
      public HumRe() { } //Default Constructor
      public HumRe(string name) : base(name) { } //Base is meaning call (base class constructor)
      public override void PrintName() //Override is inheritance form base class
      {
         Console.WriteLine($"Print Name {EmpName} From The Hum Resources Class");
      }
   }
   #endregion
   #region HumRe
   class Finance:HumRe
   {
      public new string EmpName { get; set; } // if you remove (new) into function, you see green line under variables
                                              // because this code is doing hiding and shadowing parent code (parent class) So, if you need used this
                                              //function without hidden parent Class you must use to (override) or (new) words
      public new void PrintName() // if you remove (new) into function ...
      {
         Console.WriteLine("\nPrint a Finance Emplyee Name\n");
      }
   }
   #endregion




}
