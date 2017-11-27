using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Add by Ramy for Console
    /*
//using Brothers.YoungBrothers; ///call namescape without class
using static Brothers.YoungBrothers.MyBrothers; ///Call namespace with class;

//-------------------------------------------------------------

//using Brothers.OldBrothers; ///call namescape without class (without any Problem because the name Class MyBrothers into namespace YoungBrothers and OldBrothers are similar )
using static Brothers.OldBrothers.MyBrothers; ///Call namespace with class; but The Compalier it is cannot  call any fuction  becuase the namescpace include same class MyBrothers

//---------------------------------------------------------------

///For solve this Problem Add (Alise) into namespace as:

*/
using YB = Brothers.YoungBrothers.MyBrothers; ///without static
using OB= Brothers.OldBrothers.MyBrothers; ///without static

namespace Tutorial_38_OperationsOn_NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" Thise are Ny Family\n ");
            /*

            // Brothers.YoungBrothers.MyBrothers.print(); /// You  Call The Function Full namespace ==> without used namescpace==> using Brothers.YoungBrothers;  
            // MyBrothers.print(); /// You  Call The Function  namespace ==> using static Brothers.YoungBrothers; 
            //  print(); /// You  Call The Function namespace ==> using static Brothers.YoungBrothers.MyBrothers; Call namescape without class  

            //  Brothers.OldBrothers.MyBrothers.print();  /// You  Call The Function Full namespace ==> without used namescpace==> using Brothers.OldBrothers; 
            //  MyBrothers.print(); ///without any Problem because the name Class MyBrothers into namespace YoungBrothers and OldBrothers are similar

            */
            YB.print(); //Call namespace by Alies
            OB.print(); //Call namespace by Alies
            ReadKey();

        }//Close ==>Main Function ==> static void Main(string[] args)

    }
}

namespace Brothers
{
    namespace YoungBrothers
    {
        class MyBrothers //Notes: the name Class MyBrothers into namespace YoungBrothers and OldBrothers are similar
        {
            public static void print()
            {
                Write("\nYoung Brothers are "+"Tariq" + " and " + "Ahmed\n");
            }
        }

    }// namespace YoungBrothers

    namespace OldBrothers
    {
        class MyBrothers //Notes: the name Class MyBrothers into namespace YoungBrothers and OldBrothers are similar
        {
            public static void print()
            {
                Write("\nOld Brothers are " + "Mohammed" + " and " + "Shamel\n");
            }
        }

    }// namespace OldBrothers



}// namespace Brothers
