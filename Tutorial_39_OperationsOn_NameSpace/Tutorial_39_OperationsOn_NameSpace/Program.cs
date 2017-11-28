using static System.Console;

using YB = Brothers.YoungBrothers.MyBrothers; ///without static
using OB = Brothers.OldBrothers.MyBrothers; ///without static

namespace Tutorial_39_OperationsOn_NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" Thise are Ny Family\n ");
            
            YB.print(); 
            OB.print();
            ReadKey();

        }//Close ==>Main Function ==> static void Main(string[] args)

    }
}


