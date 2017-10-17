using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_14_Structure_Type
{
    class Program
    {
        // Tutorial Example 1 Solve by Ramy 
        enum toyota : byte
        {
            RAV4 = 1,
            Camery = 2,
            Tundra = 3,
            Highland = 4
        }
        // Tutorial Example 1 Solve by Ramy 
        struct carType
        {
           public toyota modelName; // give variable: modelName : value type is :toyota
           public double modelYear; // give varibale: modelYear : value type is : double
           //public int myNumber; //Test From Ramy
        }

        // Tutorial Question 21

            enum orientation : sbyte
        {
            east=1,
            west=2,
            south=3,
            north=4
        }
        // Tutorial Question 21
        struct direction
        {
            public orientation myOrient;
            public int mydistance;
        }

        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Tutorial Example 1 Solve by Ramy 
            carType myCarType;
            int carType1;
            double modelYears1;
            Console.WriteLine("1)RAV4\n2)Camery\n3)Tundra\n4)Highlan\n\n");
            do
            {
                Console.WriteLine("Enter Your Car Type: ");

                carType1 = Convert.ToInt32(Console.ReadLine());
                               

            }
            while ((carType1 < 1) || (carType1 > 4)) ;
            Console.WriteLine("Input a model Year: ");

            modelYears1 = Convert.ToDouble(Console.ReadLine());

            myCarType.modelYear = modelYears1;
            myCarType.modelName = (toyota)carType1;

            Console.WriteLine($"\nMy Car Type is {myCarType.modelName}" + $" and The mode year is {myCarType.modelYear}\n\n");

            Console.ReadKey();
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Tutorial Example 1 From Course

        /*  
            
            carType myCarType;
            int carType = -1;
            double modelYear;
            Console.WriteLine("1) RAV4\n2) Camery\n3) Tundra\n4) Highland ");
            do
            {
                Console.WriteLine("Enter Your Car Type:");
                carType = Convert.ToInt32(Console.ReadLine());
            }
            while ((carType < 1) || (carType > 4));

            Console.WriteLine("Input a modelYear :");
            modelYear = Convert.ToDouble(Console.ReadLine());
            myCarType.modelName = (toyota)carType;
            myCarType.modelYear = modelYear;
            Console.WriteLine($"My Car Type is {myCarType.modelName} " +
            $"and the model Year is {myCarType.modelYear}");
            Console.ReadKey();

    */
    
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Tutorial Question 21 Sovle by Ramy

            //Q21/ Define a struct that contains the directions by the orientation
            //as a enum and the distance to reach a destination
            // and print the direction and that distance

            Console.WriteLine("\nTutorial Question 21\n\nQ21/ Define a struct that contains the directions by the orientation\nas a enum and the distance to reach a destination\nand print the direction and that distance\n\n ");

            Console.ReadKey();


            Console.WriteLine("1)West\n2)South\n3)East\n4)North\n\n");

            
             direction myDeriction;
            int orientation1, mydistance;

            do
            {
                Console.WriteLine("Enter Your Direction");
                orientation1 = Convert.ToInt32(Console.ReadLine());
            }
            while ((orientation1<1)||(orientation1>4));
            Console.WriteLine("Enter The Distance");

            mydistance= Convert.ToInt32(Console.ReadLine());

            myDeriction.mydistance = mydistance;

            myDeriction.myOrient=(orientation)orientation1;

            Console.WriteLine($"\nyour Derction is {myDeriction.myOrient}" + $" To  Distance  { myDeriction.mydistance} Mil \n\n");


        }
    }
}
