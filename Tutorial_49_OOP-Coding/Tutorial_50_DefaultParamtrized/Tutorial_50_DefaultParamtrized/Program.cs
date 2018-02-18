using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_50_DefaultParamtrized
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string myName = "Ahmed Ali",myName2="Amjed";
            int age2 = 55;
            
            //=====================================
            Person myObj = new Person(); // get  parameter from defult construtor
            myObj.PrintValues();
            Console.WriteLine();
            //=====================================
            Person myObj2 = new Person(myName,age2); // get  parameter from Varibles ,myName and age2
            myObj2.PrintValues();
            Console.WriteLine();
            //=====================================
            Person myObj3 = new Person(myName2); // get  parameter from Varibles ,myName2 
            myObj3.PrintValues();

            Console.ReadLine();

        }


    }
}
