using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_21_ToUpperToLowerTrimOper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial From Course

            string myString, myString2, readString, trimString;

            Console.WriteLine($"Please Enter Your String : ");

            
                 myString = Console.ReadLine();
                 myString2 = myString.ToUpper();
       
                Console.WriteLine($"{myString2}");
                 myString2 = myString.ToLower();


                 myString2 = myString.Trim(); // Trim from start and End

                 Console.WriteLine($"{myString2}\n\n");

        
            Console.ReadKey();

            char[] mytrimChar = {'i','s','r',' '}; //Trim From Start and End

            Console.WriteLine($"Please Enter Your Char : ");
            readString = Console.ReadLine();
            readString = readString.ToLower();
            trimString = readString.Trim(mytrimChar);

            //  Console.WriteLine($"{readString}" +"\n\n\n\n" + $"{trimString}");
            //  Console.WriteLine($"{trimString}");

            Console.WriteLine($"{trimString}");




        }// Close ==> static void Main(string[] args)
        //-----------------------------


    }
}
