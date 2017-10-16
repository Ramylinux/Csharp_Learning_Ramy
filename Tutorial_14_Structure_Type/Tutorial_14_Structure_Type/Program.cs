using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_14_Structure_Type
{
    class Program
    {
        // Tutorial Example 1
        enum toyota: byte
        {
            RAV4=1,
            Camery=2,
            Tundra=3,
            Highlan=4
        }
        // Tutorial Example 1
        struct carType
        {
           public toyota modelName; // give variable: modelName : value type is :toyota
           public double modelYear; // give varibale: modelYear : value type is : double
           //public int myNumber; //Test From Ramy
        }

        static void Main(string[] args)
        {
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
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


              
           
       

        }
    }
}
