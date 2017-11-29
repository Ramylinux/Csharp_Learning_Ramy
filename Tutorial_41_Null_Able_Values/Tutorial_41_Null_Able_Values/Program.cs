using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_41_Null_Able_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVariable=null;
            int? myNumber = null;
            Write($"This isMy String is null = {myVariable}\n");
            Write($"This is  My Number is null = {myNumber}\n\n");
            ReadKey();


        }//Colse Main Function ==>  static void Main(string[] args)

    }
}
