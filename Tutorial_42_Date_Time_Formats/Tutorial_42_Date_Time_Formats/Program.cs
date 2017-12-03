using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tutorial_42_Date_Time_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sdandard Date and Time
            WriteLine(DateTime.Now.ToString("hh:mm:ss\nMM dd yyyy\n\n\n"));
            WriteLine("\n\n");
            // OR
            DateTime time = DateTime.Now;
            string format = "MM dd yyyy hh:mm\n\n";
            WriteLine(time.ToString(format));
            WriteLine("\n\n");
            // OR

            DateTime time2 = DateTime.Now;                   // Use Current time
            string format2 = "MMM ddd d yyyy HH:mm\n\n";    // use specific Format
            WriteLine(time.ToString(format2));
            WriteLine("\n\n");
            // OR
            DateTime now = DateTime.Now;
            WriteLine(now.ToString("d"));
            WriteLine(now.ToString("D"));
            WriteLine(now.ToString("f"));
            WriteLine(now.ToString("F"));
            WriteLine(now.ToString("g"));
            WriteLine(now.ToString("G"));
            WriteLine(now.ToString("m"));
            WriteLine(now.ToString("M"));
            WriteLine(now.ToString("o"));
            WriteLine(now.ToString("O"));
            WriteLine(now.ToString("s"));
            WriteLine(now.ToString("t"));
            WriteLine(now.ToString("T"));
            WriteLine(now.ToString("u"));
            WriteLine(now.ToString("U"));
            WriteLine(now.ToString("y"));
            WriteLine(now.ToString("Y"));
            WriteLine("\n\n");
            //OR

            DateTime now2 = DateTime.Now;
            /// USe Space After s to avoid one-char date formate.
            string result = now2.ToString("s "); // Note Space after s
            WriteLine($"{now2} [s]={result}");
            WriteLine("\n\n");
            //OR
            
            DateTime now3 = DateTime.Today;
            for (int i=0; i<7;i++)
            {
                WriteLine(now3.ToString("dddd"));
                now3 = now3.AddDays(1);
            }
            WriteLine("\n\n");

            ReadKey();

        }// Colse ==> Main Function ==> static void Main(string[] args)


    }
}
