using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // info for get Min char and Max Char
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            Console.WriteLine("Min Char = {0}  Max Char = {1}\n",charMin,charMax );

            
          
            // write out character G and Value Character G is interger
             
            char myVar = 'G'; // Charater is between '' but streing is between ""
            int myVarValue = 'G'; // iS interger 71

            Console.WriteLine("My Character = \"{0}\" My Variable Number \"{1}\"\n ",myVar, myVarValue);

            // Convert Value 71 interger to Charater letter

            char myVarVlue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("\n My Value = \"{0}\" Convert to My Charachter = \"{1}\" ", myVarValue, myVarVlue2);


            // Convert Char G To interger 71
            char myLetter = 'R';
            int myVarVlue3 = Convert.ToChar(myLetter);

            Console.WriteLine("\n My Charachter =  \"{0}\" Convert To  My Value = \"{1}\" ", myLetter, myVarVlue3);

            Console.ReadKey();

        }
    }
}
