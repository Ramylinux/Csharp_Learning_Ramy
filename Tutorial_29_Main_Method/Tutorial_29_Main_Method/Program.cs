using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_29_Main_Method
{
    class Program
    {
        static int Main(string[] args) // You can Change static string Main(string[] args) To static int Main()
                                       // OR 
                                       // static string Main()
        {
            Console.WriteLine($"{args.Length} Command Line Arguments has Entered: ");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);

            }
            Console.ReadKey();
            return 0; // Need return because change static string Main(string[] args) to static int Main(string[] args)

        }//Colse ==> Main Function
        
    }
}
