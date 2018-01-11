using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_57_Inheritance
{
   class Cars
   {
      //The relation is "is a kind"
      // if you not add public word is defualt private
      public string model = "Camery"; // You can change this value from Object into (by)Child Class
      public string make = "Toyota"; // You can change this value from Object into (by)Child Class
      //public string year; 
      int year; //Default is Private or you can add private words to Variables //You Can Add vlaue by Object into Child Class

      public void PrintModel() { Console.WriteLine($"{model}"); }

      // setter and getter for Set and Get value private Variables
      public void setYear(int year) {this.year = year; }
      public int getyear() { return year; }

   }
}
