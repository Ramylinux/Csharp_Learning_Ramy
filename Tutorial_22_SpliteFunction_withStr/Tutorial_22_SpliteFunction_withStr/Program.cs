using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_22_SpliteFunction_withStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            Console.Write("\nPlease Enter Your Text :");
            myString = Console.ReadLine();
            char[] separator = { ' ' }; // you can add another charachter {' ' , 'u','k'}
            string [] mynewWords;
            mynewWords = myString.Split(separator);

            
            Console.WriteLine($"\nYour Text is : {myString}\n");
             foreach (string words in mynewWords)
             Console.WriteLine($"{words}\n");





        }


    }
}
