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


            // Convert Char R To interger 82
            char myLetter = 'R';
            int myVarVlue3 = Convert.ToChar(myLetter);

            Console.WriteLine("\n My Charachter =  \"{0}\" Convert To  My Value = \"{1}\" ", myLetter, myVarVlue3);



            // Convert Char 82 To interger R
            char myVarVlue4 = Convert.ToChar(82);

            Console.WriteLine("\n My Value =  \"{0}\" Convert To  My Charachter = \"{1}\" ", 82, myVarVlue4);


            //String
            string myString = "Welcome To ";
            Console.WriteLine("\n === My String is ==== {0}\n ", myString);


            // Booling

            bool myBool = true; // or false

            Console.WriteLine("My Boolean Value is = {0}\n", myBool);


            // Question : Printe the variable in this Form " This is My Character "A" Value "??" and this is My Character "a" value "??" 

            char Char_A = 'A';
            char char_a = 'a';
            int MyVlue_A = Convert.ToChar(Char_A);
            int myVlue_a = Convert.ToChar(char_a);

            Console.WriteLine("\n This is My Character \"{0}\" Value = \"{1}\" and this is My Character \"{2}\" value = \"{3}\"\n" , Char_A ,MyVlue_A, char_a,myVlue_a);

            // Or another Soulation for Question
            int myVar1 = 'A', myVar2 = 'a';
            string myString1 = "This is my character A value ", myString2 = " This is my character a value ";
            Console.WriteLine("\"" + myString1 + myVar1 + myString2 + myVar2 + "\"");
            
            // OR

            int myletter1 = 'R', myletter2 = 'r';

            Console.WriteLine("\nMy Letter \"R\" is = {0} and My Small letter is \"r \" is = {1}\n", myletter1,myletter2);
            Console.WriteLine("Myletter R =" + "\""  +myletter1+ "\" " + "MyLetter r =" + "\""  +myletter2 + "\"");

            Console.ReadKey();



           

        }
    }
}
