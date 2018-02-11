using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_69_Implicit_Casting
{
   class Program
   {
         #region Casting examples
         static void ObjectCastingMethod()
     {
         // A Manager "is-a" System.Object. therefore, we can 
         // Store a Manager reference in an object variable hust fine.
         object jasim = new Managers("Jasim Kareem",50,30,400,"141.14.1278",5);

         // A Manager "is-an" Employess too.
         Employee hussein = new Managers("Hussein Abed",27,22,20000,"151-141-1321",1);
         GivePromotion(hussein);
         hussein.DisplayEmpInfo();

         // A Finance "is-a" HumanRes.
         HumanRes karwan = new Finance("Karwan",34,3002,100000,"123-22-1799",90);
         GivePromotion(karwan);
         karwan.DisplayEmpInfo();
     }
      #endregion
      #region Example of "is" keyword in action
      static void GivePromotion(Employee emp)
      {
         Console.WriteLine("{0} was Promoto !" , emp.Name);
         if (emp is HumanRes)
         {
            Console.WriteLine("Human Resources {0} had  {1} employee(s)!...",emp.Name,((HumanRes)emp).EmpNumber);
            Console.WriteLine();
         }
         if (emp is Managers)
         {
            Console.WriteLine("Manager {0} had  {1} employee(s)!...", emp.Name,((Managers)emp).EmployeeNumber);
            Console.WriteLine();
         }

      }
#endregion

      static void Main(string[] args)
    {
         ObjectCastingMethod();
         
     }
   }
}
