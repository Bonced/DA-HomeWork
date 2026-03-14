using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
          
            while (true)
            {
                Console.WriteLine("Enter first number:");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    break; 
                }
                Console.WriteLine(" Error: This is not an integer. Please try again");
            }

            while (true)
            {
                Console.WriteLine("Enter second number:");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    break;
                }
                Console.WriteLine("Error: This is not an integer. Please try again");
            }

            double avg = (a + b) / 2.0;
            Console.WriteLine($"✅ Average = {avg}");
        }
    }
}
