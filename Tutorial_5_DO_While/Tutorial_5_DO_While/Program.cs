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
                
                mySalary += 20; //mySalary = mySalary + 20;
                Console.WriteLine($" Total={mySalary}");
                i++;

            } while (mySalary < max);
            j = i / 12;       
                Console.WriteLine($" $20 increment per Year Need to = {i} years \n\n $20 increment per Month Need to = {j} Years \n\n\n");
            Console.ReadKey();
            /*===============================================================*/
            //OR

            int salary = 1000, increment = 20, salarydesired = 2000;
          int ii = 0;
            do
            {
                salary += increment;
                Console.WriteLine($" Total={salary}");
                ii++;

            } while (salary < salarydesired);
            Console.WriteLine($" Years={ii}");
            float years = ii / 12F; // OR  int years = ii / 12;
            Console.WriteLine("{0}\n{1}", ii, years);
            Console.ReadKey();



        }
    }
}
