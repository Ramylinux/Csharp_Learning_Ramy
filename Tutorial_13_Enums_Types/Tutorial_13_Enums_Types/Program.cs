using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_13_Enums_Types
{
    class Program
    {
        //Eample 1 - Ramy abu-dhair
        enum myName : int
        {
            ramy,
            abudhair=2
        }

        // Eample 2 - Tutorail
       enum humanSex : sbyte
        {
            male = 1,
            female = 2
        }
        //Question 20  From Tutorail
        // Tutorial 13_enums ==> Question
        enum orientation : sbyte
        {
            west=2,
            east,
            south,
            north
        }


        static void Main(string[] args)
        {
            //Example 1 - Ramy abu-dhair
            Console.WriteLine($"\n\nExample 1 - Ramy abu-dhair\n\n");

            sbyte nameSbyte;
            string stmyName;
            // myName myNameAll = myName.abudhair;
            //OR 
            myName myNameAll;
            myNameAll = myName.abudhair;
            

            Console.WriteLine($"print vaule for myNameAll is = {myNameAll} \n");

            nameSbyte = checked((sbyte)myNameAll); // convert int to sbyte
            Console.WriteLine($"Convert value(myNameAll) ==> int to sbyte and print index for value == myName.abudhair is = {nameSbyte}\n");

            stmyName = Convert.ToString(myNameAll);


            Console.WriteLine($"Convert value(myNameAll) ==> int to string and print string for value stmyName is = {stmyName}\n");
            Console.WriteLine($"\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.ReadKey();

            //Example 1 - Ramy abu-dhair
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //Example 2  From Tutorail
            Console.WriteLine($"\n\nExample 2 - From Tutorail\n\n");
            sbyte humanSbyte;

                        humanSex myhumanSex = humanSex.male;
                        Console.WriteLine($"Human Sex =  {myhumanSex}" + "\n");
                        humanSbyte = (sbyte)myhumanSex;
                        Console.WriteLine($"Human Gender index in  = {humanSbyte}" + "\n");
                        string humanGender;
                        humanGender = Convert.ToString(myhumanSex);
                        Console.WriteLine($"Human associated with this index = {humanGender}" + "\n");
                 Console.WriteLine($"\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.ReadKey();

            //Example 2  From Tutorail

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //Question 20  From Tutorail
            Console.WriteLine($"\n\nQuestion 20  From Tutorail\n\n");

                                                
            string stmyOrient,subStmyOrient,insidemyOrient;
            sbyte sbmyOrient;
          int intmyOrient;
           
             orientation myOrient = orientation.south;
            //orientation myOrient;
            Console.WriteLine($"\nPrint emums for orientations is =  {myOrient} ");
            
            stmyOrient = Convert.ToString(myOrient);
            Console.WriteLine($"\nPrint string for orientations is = {stmyOrient} ");

            subStmyOrient = stmyOrient.Substring(1); //Notes:  print form index 1 for end the words 
            Console.WriteLine($"\nPrint substring for orientations to check is Converter to string is OK =  {subStmyOrient} ");

            sbmyOrient = checked((sbyte)myOrient); // OR sbmyOrient = (sbyte)myOrient;
            Console.WriteLine($"\nPrint index emums for orientations.south is =  {sbmyOrient} ");


            //Q20/ Define an Enum variable for orientation and print the contents usign loop and start from index 2

            Console.WriteLine($"\n\n\n\nQuestion 20  From Tutorail\n\nQ20/ Define an Enum variable for orientation and print the contents usign loop\nand start from index 2\n\n");


            for (sbyte i=(sbyte)orientation.west; i<= (sbyte)orientation.north; i++) // Convert value orientation to sbyte then print value number
            {
                Console.WriteLine($"\nPrint ALL index enums  for orientations is =  {i}\n ");
                
            }
            Console.WriteLine($"\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.ReadKey();

          
            Console.WriteLine("\n");
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

   

        }
    }
}
