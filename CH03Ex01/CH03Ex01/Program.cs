using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "This string has a line break ---> \n\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();
            
         }
    }
}