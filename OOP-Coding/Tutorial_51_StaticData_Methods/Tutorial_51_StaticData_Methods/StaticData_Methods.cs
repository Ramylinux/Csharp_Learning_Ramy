using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_51_StaticData_Methods
{
    class StaticData_Methods
    {
        // Static Data at Instance-level.
        public double currBalance; // Call by Object for this class

        // A static point of data.
        //public static double currInterestRate;
        public static double currInterestRate; //Call by Class

        //Parameterized Constructor
        public StaticData_Methods(double balance)
        {
            currBalance = balance;
         //   currInterestRate = 0.5;
            
        }

        //Static constructor 
        static StaticData_Methods() //none parametars constructor  
        {
            currInterestRate = 0.5;  //this Value used one time when create instance objects
        } // After this static constructor the funcetion Getvalue  read value = 0.7 SO, if this function not avalabile, The Getvalue function  read value = 0.5


        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetValue()
        { return currInterestRate; }

       

    }
}
