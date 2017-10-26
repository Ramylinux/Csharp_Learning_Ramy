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

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();

            char[] mytrimChar = { 'i', 's', 'r', ' ' }; //Trim From Start and End

            Console.WriteLine($"Please Enter Your Char : ");
            readString = Console.ReadLine();
            readString = readString.ToLower();

            trimString = readString.TrimStart(mytrimChar);
            Console.WriteLine($"Traim Start :\n{trimString}");

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();

            trimString = readString.TrimEnd(mytrimChar);
            Console.WriteLine($"Traim End :\n{trimString}");

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();

            trimString = readString.PadLeft(55, 'L');
            Console.WriteLine($"pad left :\n{trimString}");

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();

            trimString = readString.PadRight(55, 'R');
            Console.WriteLine($"pad right :\n{trimString}\n\n\n\n");

            //  Console.WriteLine($"{readString}" +"\n\n\n\n" + $"{trimString}");
            //  Console.WriteLine($"{trimString}");

            //++++++++++++++++

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();
            //Q25
            //Change this string from this style "Hello My Dear" to be 
            //in this style "Hello My Dearest" using pads functions only


            // Questopn 25

            Console.WriteLine("Question 25:\n Change this string from this style \"Hello My Dear\" to be \nin this style \"Hello My Dearest\" using pads functions only\n\n\n");

            string myWords,padString;

            myWords = "Hello My Dear";
                                   

            Console.WriteLine($"{myWords}\n");

            padString = myWords.PadRight(13);

            Console.Write($"{padString}");
            Console.WriteLine("est");

            Console.WriteLine("\nPress Enter for continue ..\n");
            Console.ReadKey();

            // Another Example 1

            
            int[] noArray = new int[]  {1,40,6,700};

            // Output the header. 
            Console.Write("Letter".PadRight(10));  // After letter add space
            Console.WriteLine("Number".PadLeft(8));// Befor number add space

            // Output array.
            foreach (int i in noArray)
            {
                Console.Write("A".PadRight(10));
                Console.WriteLine(i.ToString().PadLeft(8));
            }
            Console.WriteLine("\nThank You ..\n");
            Console.ReadKey();

            
            



        }// Close ==> static void Main(string[] args)
        //-----------------------------


    }
}
