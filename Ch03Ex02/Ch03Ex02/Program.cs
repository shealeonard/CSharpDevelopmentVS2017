using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from " + $"{firstNumber} is {firstNumber - secondNumber}.");            
            Console.WriteLine($"The product of {firstNumber} & {secondNumber} is " + $"{firstNumber * secondNumber}.");            
            Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is " + $"{firstNumber / secondNumber}.");           
            Console.WriteLine($"The remainder after dividing {firstNumber} by {secondNumber} is " + $"{firstNumber % secondNumber}");            
            Console.ReadKey();
            */

            string question1;
            string question2;
            string question3;
            string question4;
            double doubles1, doubles2;
            doubles2 = 5;

            Console.WriteLine("Hello how are you?");
            question1 = Console.ReadLine();
            Console.WriteLine("How's your oul Da sir?");
            question2 = Console.ReadLine();
            Console.WriteLine("Would ya like slap sir?");
            question3 = Console.ReadLine();
            Console.WriteLine("Well I'm going to stick the head on ye instead sir!?!?!");
            question4 = Console.ReadLine();
            Console.WriteLine("How many fingers am I holding up after ye took that slap sir?");
            doubles1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Wrong it was this many {doubles2} ya cunt ye your getting another thump!!!!");
            Console.ReadKey();
        }
    }
}
