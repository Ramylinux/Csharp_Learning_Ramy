using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_6_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example about For Loop
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int testSalary = 1000, testTotal = 0;

            for(int testI=0;testI < 12; testI +=3 /*Or increment as ==>  testI += N ==> testI += 3  */)
            {
                testTotal += testSalary;
                Console.WriteLine("My Salary for 12 months is {0}", testTotal);
            }
            Console.ReadKey();
/*================================================================================================================================================*/
            //Q1: Find How many Years do you Need To Reach $2000 if your Salary was $1020 and and the increment precentage was $20 per month and print the result;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Q1: Find How many Years do you Need To Reach $2000 if your Salary was $1020 and \nthe increment precentage was $20 per month and print the result;\n\n");
            Console.ReadKey();

            int manyYears = 0, maxSalary = 2000, yourSalary = 1020, incrementmanth = 20, manyj=0;
            for ( manyj=0; yourSalary < maxSalary;  manyj++)
            {
                yourSalary += incrementmanth;
                
                Console.WriteLine($"\n\n Increment per monthe 20 is your salary {yourSalary} \n\n  ");
            }
            manyYears = manyj / 12;
            Console.WriteLine($"\n\n Need to years is {manyYears} years \n\n");
            Console.ReadKey();

   /*================================================================================================================================================*/
   
            //Q2: Find how many exercises do need to reach 83kg if your weight was 120kg and each exercise will make you lose 1kg and prind the result

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\nQ2: Find how many exercises do need to reach 83kg if your weight was 120kg \nand each exercise will make you lose 1kg and prind the result;\n\n");
            Console.ReadKey();

            int manyEx = 0, minEx = 83, yourWeight, oneEx =1;

            for (yourWeight=120; yourWeight > minEx;yourWeight--)
            {
               // yourWeight = yourWeight-oneEx;
                manyEx++;

                Console.WriteLine($" \n\n one Exercies you lose 1 KG so Now your Weight is = {yourWeight}\n\n ");
               
            }
            Console.WriteLine($"\n You Need to {manyEx} Exercies to become are your weight = 83 KG\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
           
            /*================================================================================================================================================*/




        }
    }
}
