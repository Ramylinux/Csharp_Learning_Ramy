using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_37_Multi_Delegate_Type
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myXNumber = 3;
        static int addFuct(int number)
        {
         
            myXNumber += number;
            return myXNumber;
        }
        static int mulFun(int number)
        {
            myXNumber *= number;
            return myXNumber;
        }
        static void Main(string[] args)
        {
            
            MyNewNumber n1 = new MyNewNumber(addFuct); // Call the delegate to Add (sum) function 
            MyNewNumber n2 = new MyNewNumber(mulFun); // Call the delegate to Multiple function

           n1(4); // n1(4) to replace with  ==>  static int addFuct(int number value)

            Console.WriteLine($"\nDelegate Value n1 ={myXNumber}\n");

            n2(5);  //  n2(5) to replace with  ==>  static int mulFun(int number value)
            Console.WriteLine($"\nDelegate Value n2 = {myXNumber}\n");

            // ==> Need to Printing to MuliCasting Delegate on the time 
            MyNewNumber n; // Call Delegate and give him value = n;

            n = n1 + n2; //  call MultiCasting Delegate by value n; 
            // Notes: 
            //n =n1+n2 is meaning  (n=n1) (n=n2)
            //(n=n1) ==> n1( myXNumber = myXNumber(laset Number get it is =35) + number(n(5));) ==> myXNumber=35+5=40
            //(n=n2) ==> n2(myXNumber = myXNumber(laset Number get it is =40) * number(n(5));)==> myXNumber=40*5=200
            // So n value is n=200
            
            n (5); // Give delegate n value = 5 this Value to replace with (int number)into function
            Console.WriteLine($"\nMultiCasting Delegate Value n= {myXNumber}\n");

            Console.ReadKey();
              


        }//Close ==>Main Function ==> static void Main(string[] args)


    }
}
