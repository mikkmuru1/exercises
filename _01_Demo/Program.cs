using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Small_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Text.
            Console.WriteLine("Enter two random numbers between [1-100] and I will add them.");

            //Ask for first number.
            Console.Write("First number:");
            string input = Console.ReadLine();
            int num1 = int.Parse(input);

            //Ask for second number.
            Console.Write("Second number:");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);
            
            //Add two number and display the sum.
            Console.Write("Sum is:"num1 + num2);

            //Press any key to close program.
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            
        }
    }
}
