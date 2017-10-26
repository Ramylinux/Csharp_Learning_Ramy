using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_20_String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tutorial From Course
            string myString = "Hello My Friends";
            char[] myCharArray = myString.ToCharArray(); // Convert string to Charachter Array 

            Console.WriteLine($"The String length is : {myCharArray.Length}"); 
            // OR // Console.WriteLine($"The String length is : {myString.Length}");


            foreach (char myChar in myCharArray)
                Console.WriteLine($"{myChar}");

            Console.ReadKey();
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // Question 25
            // Q25 / Define a string Variable  that assign " I am Smart"
            //Change the substring "I am" with "He is" ==> "He is Smart"

            Console.WriteLine("\n\nQuestion 25\nDefine a string Variable  that assign \" I am Smart\"\nChange the substring \"I am\" with \"He is\"\n ==>\"He is Smart\"\n\n ");
            Console.ReadKey();
  //=======================================================================        
            string mySmart = "I am Smart ", heisSmart="He is Smart",iamSmart="I am Smart ";

            char[] mySmartArray = mySmart.ToCharArray();
            char[] iamSmartArray = iamSmart.ToCharArray();
            char[] heisSmartArray = heisSmart.ToCharArray();
 //=======================================================================          

            Console.Write("This Sentenance Without Change : ");

             foreach (char noChange in mySmartArray)
              Console.Write($"{noChange} ");
              Console.WriteLine("\n\n");

            //=========================================================================
            // Change the substring "I am" with "He is" ==> "He is Smart" 

            // Console.Write($"{mySmartArray[i]} ");
        
            // for (int j = 0; j < iamSmartArray.Length; j++)
            for (int j = 0; j < mySmartArray.Length; j++)
            {
                    if (mySmartArray[j] == iamSmartArray[j])
                    {
                    mySmartArray[j] = heisSmartArray[j];
                    if (j > 5)
                        continue;
                      }

       //Console.Write($"{mySmartArray[j]} ");
            }
            
            Console.WriteLine("\n\n");
          for (int i = 0; i < mySmartArray.Length; i++)
           {
               Console.Write($"{mySmartArray[i]} ");

            }

            Console.WriteLine("\n\n");


            Console.WriteLine($"\nThe String length this is array : {mySmartArray.Length}");



            //==========================================

            // Another Soluation

            Console.WriteLine("Another Solution :\n\n");
            char [] myTrimChar = { 'I', 'a','m'};
            mySmart = mySmart.TrimStart(myTrimChar);
            mySmart = mySmart.PadLeft(6);
            Console.WriteLine($"He is{mySmart}\n\n");
            


        }//Colse ==> static void Main(string[] args)

    }
}
