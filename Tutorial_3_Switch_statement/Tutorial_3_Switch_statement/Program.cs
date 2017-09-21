using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3_Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatHesay;
            whatHesay = "Hello";
            switch (whatHesay)
                {
               
                case "Baye":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Baye\n\n\n");

                    break;
                case "Welcome":
                    Console.WriteLine("Welcome\n\n");
                    break;
                case "Hello":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Hello\n\n");
                    break;
                default:
                   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No one\n\n");
                    break;
                   
            }


            Console.ReadKey();



        }
    }
}
