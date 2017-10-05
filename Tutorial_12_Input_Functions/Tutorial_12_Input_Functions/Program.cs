using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_12_Input_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example
            //ReadLine , Read Functions

            string myName,myStrNumber;
            char myChar;
            int myVar1, myVar2;

     // Enter Your name
            Console.WriteLine("Please Enter your name\n"); //  Note:  This is sentance must be before function "Console.ReadLine();"  until you see the sentance

            myName = Console.ReadLine();

    //Enter Number
            Console.WriteLine("\n\nPlease Enter your first Number\n\n");
             //myStrNumber = Console.ReadLine();
            //myVar1 = Convert.ToInt32(myStrNumber);
            //Console.WriteLine($"\nyou Entered The Number is: {myVar1}\n");
            // OR   
            // you Can Short the code : No Need Virables myStrNumber
            myVar1 = Convert.ToInt32(Console.ReadLine());

    //Enter Charachter
           Console.WriteLine("\nEnter Your Entry (Charachter)\n\n");
            myVar2 = Console.Read();

    // Convert ISSC character to Letter Character
            myChar = Convert.ToChar(myVar2);

    // Printing Result :
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\nHello {myName}\n");
            
            Console.WriteLine($"\nyou Entered The Number is: {myVar1}\n");

            Console.WriteLine($"\nyou Entered The Entery is ISSC Char: {myVar2} is Char = \"{myChar}\"\n\n\n Thank You \n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Go To Next Pages ...\n Thank You \n ");
            Console.ReadKey();

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            /*
            Q-19/ Define  4 Variables
            1- first Name
            2-Last Name
            3-Salary
            4- TaxRate = 0.07 // 7%
            5- Enter all these values from the console windows and then
            Fins the Salary for 12 month and cut the TaxRate for 12 months and
            Print the Salary : (in this Form)
            * Welcome fName , lName
            * Your Salary for 12 months is #$
            * You paid TaxRate for 12 months #$
            * Good Bye
            
            */
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            string fName, lName;
            double fSalary, resultTaxt,resultSalaryTaxt,resultSalaryYears,fTaxtRate=0.07d;

            Console.ForegroundColor = ConsoleColor.Red;
                                  
            Console.WriteLine("\nPlease Enter Full Name :\n");
            Console.ReadLine();

           Console.WriteLine("\nPlease Enter the First Name :\n");
             fName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter the Last Name :\n");
            lName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Your Salary\n");
            fSalary = Convert.ToDouble(Console.ReadLine());

           
            //Operations

            resultSalaryYears = fSalary * 12;
            resultTaxt = resultSalaryYears * fTaxtRate;
            resultSalaryTaxt = resultSalaryYears - resultTaxt;

            //
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\nWelcome Mr {fName}  {lName} \n\n Your Salary for 12 months is = {resultSalaryYears}\n TaxRate 7%  your Salary for 12 months is = {resultTaxt} \n Your Salary After Cut Tax for 12 months is = {resultSalaryTaxt} \n\n  ");
                        
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Good Bye \n ");
            Console.ReadKey();

        }


    }
}
