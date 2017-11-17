using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add UTF8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Display Name and Address
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main St.");
            Console.WriteLine("----------------------------------------------------------");

            double total = 0;

            //Ask user to enter price of items and display them, continue until [-1].
            while (true)
                {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();

                

                //change string input to decimal value
                double value = double.Parse(input);

                if (value == -1)
                    break;

                    total = total + value;
                                         
                }

            double gratuity = total * 0.15;

           

                    //Calculate sum, gratuity and display total
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine($"Total                            :{total:F2}€");
                    Console.WriteLine($"15% of Gratuity                  :{gratuity:F2}€");
                    Console.WriteLine($"Subtotal                         :{(total-gratuity):F2}€");
                //
                
            
            //Press any key to continue.
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
        
        }
    }
}
