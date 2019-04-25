using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;

            Console.WriteLine("Give me a number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The product of { firstNumber }, { secondNumber }, {thirdNumber}, and {fourthNumber} is " + $"{firstNumber * secondNumber * thirdNumber * fourthNumber}.");
        }
    }
}
