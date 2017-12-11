using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_47_Optional_Parameters
{
    class Program
    {
        public static void PrintValues(string name = "Ramy AbuDhair", int myValue = 7)
        {
            Console.WriteLine($"Name  = {name}  Number  = {myValue}");

        }

        static void Main(string[] args)
        {
            string name = "Ahmed";
            int value = 15;
            PrintValues();
            PrintValues(name);
            PrintValues(name, value);
            PrintValues(name: "Hammad", myValue: 6);
            Console.ReadKey();
           

        }//Close ==> Main Function ==> static void Main(string[] args)

    }
}
