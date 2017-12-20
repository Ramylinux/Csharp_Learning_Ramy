using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_50_DefaultParamtrized
{
    class Person
    {
        //Member varibles for Class
        string name;
        int age;
        public void PrintValues() { Console.WriteLine($"{name}, {age}"); }

        //Defult Constructor
        public Person() // You Can Remove public words but mybe you con't access from outside class
        {
            name = "Ramy Abu-Dahir";
            age = 39;

        }

        // parametrized Constructor with one parametor

        
    public Person(string value)
    {
        name = value;
        age = 20;
    }
   /*
        //OR  
        //Using (this) word
        // if names member variables are as same as names class paremters  
        //Example
        public Person(string name)
        {
            this.name = name;
            age = 20;
        }

 */

        // parametrized Constructor with Two parametor
        public Person(string value2,int myAge)
        {
            name=value2;
            age = myAge;
        }


       

    }
}
