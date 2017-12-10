using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_45_GoTo
{
    class Program
    {
        static int MyFunction()
        {
            int counter = 0;
            for (int i=0;i<10;i++)
            {
                for (int j=0;j<10;j++)// Untel Condition Execute
                {
                    if (j==5)
                    {
                        goto MyLabel1;
                    }
                    counter++;
                }
            MyLabel1:
                continue;
            }
            return counter;
        }//Close ==> static int MyFunction()
        static void Main(string[] args)
        {
            WriteLine(MyFunction());
            ReadKey();

        }//Close ==>  static void Main(string[] args)

    }
}
