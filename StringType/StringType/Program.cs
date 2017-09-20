using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {

            // \' \" \\ \0 \a \b \n \r \t \v \f  
            // @

            string myString = "This is My String Variable,new sales ok\b.";

            string myPath = @"c:\windows\system32";
            
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{myString}\n\n {myPath}");
                        
           

            string myStr = @"Ramy has said ""This is args unique course,"" and I think so ";

            Console.WriteLine($"\n\n\n{ myStr}\n\n");

            // OR

            string myStr1 = "Ramy has said \"This is args unique course,\" and I think so ";

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(myStr1);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.ReadKey();

        }
    }
}
