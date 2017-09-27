using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_5_DO_While
{
    class Program
    {
        static void Main(string[] args)
        {
  
  //Q1: Find How many Years do you Need To Reach $2000 if your Salary was $1020 and and the increment precentage was $20 per month and print the result;

            int  mySalary = 1020, max = 2000;
            int i = 0, j = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                mySalary += 20; //mySalary = mySalary + 20;
                Console.WriteLine($" Total={mySalary}");
                i++;

            } while (mySalary < max);
            j = i / 12;       
                Console.WriteLine($" $20 increment per Year Need to = {i} Years \n\n $20 increment per Month Need to = {j} Years \n\n\n");
            Console.ReadKey();
            /*===============================================================*/
            //OR

            int salary = 1000, increment = 20, salarydesired = 2000;
          int ii = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                salary += increment;
                Console.WriteLine($" Total={salary}");
                ii++;

            } while (salary < salarydesired);
            Console.WriteLine($" Years={ii}");
            float years = ii / 12F; // OR  int years = ii / 12;
            Console.WriteLine("{0}\n{1}", ii, years);
            Console.ReadKey();
            /*===============================================================*/
            //Q2:( USED while without DO) Find How many Years do you Need To Reach $2000 if your Salary was $1020 and and the increment precentage was $20 per month and print the result; 

            int salarynew = 1020, incrementnew = 20, maxsalary = 2000,inew=0;
            double jj = 0.0;
            while (salarynew < maxsalary)
            {
                salarynew += incrementnew;
              //  Console.WriteLine($"\n\n Total={salarynew}");
                inew++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            jj = inew / 12D; // or jj = inew / 12;

            Console.WriteLine($" \n\n\nif $20 increment Month so MAX salary is  = {salarynew} $ \n\n and Need to = {jj} Years \n\n\n");

            Console.ReadKey();

            /*===============================================================*/
            //Q3: ( USED while without DO)Find how many exercises do need to reach 83kg if your weight was 120kg and each exercise will make you lose 1kg and prind the result

            int minEx = 83,myWeightnow=120,oneEx=1,manyEx=0;

            while (myWeightnow > minEx)
            {
                myWeightnow--;
                Console.WriteLine($"one Exercies you lose 1kg Now your weight is = {myWeightnow} KG \n  ");
                manyEx++;
            }
            Console.WriteLine($"\n\nYou Need to = {manyEx} Exercises for become your weight = 83 KG \n  ");

            Console.ReadKey();

            /*===============================================================*/
            //OR

            int myWeight = 120, desiredWeight = 83, ix = 0;
            int losePerExercise = 1;
            while (myWeight > desiredWeight)
            {

                myWeight = myWeight - losePerExercise;
                ix++;
            }
            Console.WriteLine(ix);
            Console.ReadKey();
            /*===============================================================*/


        }
    }
}
