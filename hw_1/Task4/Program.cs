using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 4;


            int sum = a + b;
            int mult = a * b;
            int div = a / b;
            int sub = a - b;


            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {mult}");
            Console.WriteLine($"Quotient: {div}");
            Console.WriteLine($"Difference: {sub}");

        }
    }
}
