using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tutorial_40_LambdaExpression
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myXNumber = 3;
        /*    
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
        // go to main function
        */
        static void Main(string[] args)
        {

            //MyNewNumber n1 = new MyNewNumber(addFuct); /// Call the delegate to Add (sum) function 
            //n1(4); /// n1(4) to replace with  ==>  static int addFuct(int number value)
            
            //MyNewNumber n2 = new MyNewNumber(mulFun); // Call the delegate to Multiple function
            //n2(5);  ///  n2(5) to replace with  ==>  static int mulFun(int number value)

            // Console.WriteLine($"\nDelegate Value n1 ={myXNumber}\n");
            //Console.WriteLine($"\nDelegate Value n2 = {myXNumber}\n");

            MyNewNumber n1 = x => x + myXNumber; /// Lambda Expression to replace with Add (sum) function
            Console.WriteLine($"\nDelegate Value n1 ={n1(4)}\n");

            MyNewNumber n2 = x => x * myXNumber; /// Lambda Expression to replace with  Multiple function
            Console.WriteLine($"\nDelegate Value n2 = {n2(5)}\n");

            // ==> Need to Printing to MuliCasting Delegate on the time 
             MyNewNumber n; /// Call Delegate and give him value = n;

            n = n2 + n1; //value n pass to x=6 into finction n1 ==>   (6+3=9) 
                         //n =n2+n1 is meaning  (n=n2) (n=n1)
                         //(n=n2) ==> n2(n2 = x(6) * myXNumber(3);)==> n=6*3=18
                         //(n=n1) ==> n1( n1 = X(6) + myXNumber(3);) ==> n=6+3=9
                         // So last value for n is (n=9)
                         // OR 
                         //n = n1 + n2; // value n2 pass to x=6 into finction n2 ==>  (6*3=18) So last value for n is (n=18)

            Console.WriteLine($"\nDelegate Value n = {n(6)}\n");

            /*
            n = n1 + n2; //  call MultiCasting Delegate by value n; 
                         // Notes: 
            //n =n1+n2 is meaning  (n=n1) (n=n2)
            //(n=n1) ==> n1( myXNumber = myXNumber(last Number get it is =35) + number(n(5));) ==> myXNumber=35+5=40
            //(n=n2) ==> n2(myXNumber = myXNumber(last Number get it is =40) * number(n(5));)==> myXNumber=40*5=200
            // So n value is n=200
            // But Notes if change this parametars to n=n2+n1
            // Notes
            // n =n2+n1 is meaning  (n=n2) (n=n1)
            //(n=n2) ==> n2( myXNumber = myXNumber(last Number get it is =35) + number(n(5));) ==> myXNumber=35*5=175
            //(n=n1) ==> n1(myXNumber = myXNumber(last Number get it is =175) * number(n(5));)==> myXNumber=175+5=180
            // So n value is n=180
 
            n(5); // Give delegate n value = 5 this Value to replace with (int number)into function
            Console.WriteLine($"\nMultiCasting Delegate Value n= {myXNumber}\n");
           */
            
            //--------------------------------------------------------------------------------------------------
            Console.ReadKey();
            //--------------------------------------------------------------------------------------------------
            // Example
            Func<int, bool> func2 = (x=> x % 2 !=0);
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(func2.Invoke(myArray[i]));
            Console.ReadKey();

            // Question 30
            // Write a lambda expression example to find the numbers bigger than 10 in any array of numbers
            Console.WriteLine(@"//Question 30 
//Write a lambda expression example to find the numbers 
//bigger than 10 in any array of numbers"+"\n\n");

           int[] bigArray = { 4, 1, 5, 80, 10, 2, 60 };
            
            /*
            int bigSize = 1,ii = 0;
            for (int j=0;j<bigArray.Length;j++) 
            {
                if (bigArray[ii] < bigArray[j])
                {
                    if (bigSize < bigArray[j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        bigSize = bigArray[j];
                    }

                }

                else if ((bigSize < bigArray[ii]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    bigSize = bigArray[ii];

                }

            }

            Console.WriteLine($"\n Big Number is variable j: = {bigSize}\n ");

            Console.WriteLine("\n\n ");

            Console.ForegroundColor = ConsoleColor.White;
            */

            Console.ReadKey();



        }//Close ==>Main Function ==> static void Main(string[] args)


    }
}