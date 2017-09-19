using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            // info for read Float Max and Min
            float flMain = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("Min Value = {0} Max Value = {1}",flMain,flmax );

            // info for get difference between fload,double and dcimal  
            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("\n Float Value = {0}\n Double Value = {1}\n  Decimal Value={2}\n" ,flVar, dlVar, dcVar);
            
            //OR for Printing

            Console.WriteLine($"\n Float Value = {flVar}\n Double Value = {dlVar}\n Decimal Value = {dcVar}\n ");


            Console.ReadKey();
        }
    }
}
