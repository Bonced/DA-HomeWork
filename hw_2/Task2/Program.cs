using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Встановіть значення відповідно до вашого варіанту (наприклад, візьмемо типові)
            int a = 5;
            int b = 10;

            Console.WriteLine("--- Початкові значення ---");
            Console.WriteLine("a = " + a + ", b = " + b);

            // ПРИКЛАД ВИРАЗУ (замініть на той, що у вашому варіанті!)
            // Допустимо, вираз: result = a++ + ++b;

            int result = a++ + ++b;

            /* Ручний аналіз для прикладу:
               1. Дивимось на ++b (префікс): b стає 11, у вираз іде 11.
               2. Дивимось на a++ (постфікс): у вираз іде поточне a (5), а ПОТІМ a стане 6.
               3. result = 5 + 11 = 16.
               4. Кінцеві значення: a = 6, b = 11, result = 16.
            */

            Console.WriteLine("\n--- Результат обчислення ---");
            Console.WriteLine("result = " + result);
            Console.WriteLine("a (після обчислення) = " + a);
            Console.WriteLine("b (після обчислення) = " + b);

            Console.WriteLine("\nНатисніть Enter для виходу...");
            Console.ReadLine();
        }
    }
}
