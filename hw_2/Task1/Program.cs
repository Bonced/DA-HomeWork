using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Ввод числа
            Console.Write("Введіть ціле чотирицифрове число: ");
            int number = int.Parse(Console.ReadLine());

            // 2. Выделение каждой цифры в отдельные переменные (согласно условию)
            int digit1 = number / 1000;          // Тысячи
            int digit2 = (number / 100) % 10;    // Сотни
            int digit3 = (number / 10) % 10;     // Десятки
            int digit4 = number % 10;            // Единицы

            Console.WriteLine("Цифри числа: " + digit1 + ", " + digit2 + ", " + digit3 + ", " + digit4);

            // 3. Формируем новое число, где первая (digit1) и последняя (digit4) поменяны местами
            int swappedNumber = (digit4 * 1000) + (digit2 * 100) + (digit3 * 10) + digit1;
            Console.WriteLine("Число з переставленими цифрами: " + swappedNumber);

            // 4. Находим самую большую и самую маленькую цифры
            int maxDigit = Math.Max(Math.Max(digit1, digit2), Math.Max(digit3, digit4));
            int minDigit = Math.Min(Math.Min(digit1, digit2), Math.Min(digit3, digit4));

            // 5. Вычисляем среднее арифметическое (используем 2.0 для точности)
            double average = (maxDigit + minDigit) / 2.0;

            Console.WriteLine("Найбільша цифра: " + maxDigit);
            Console.WriteLine("Найменша цифра: " + minDigit);
            Console.WriteLine("Середнє арифметичне Max та Min: " + average);

            // Ожидание нажатия клавиши
            Console.WriteLine("\nНатисніть Enter, щоб завершити...");
            Console.ReadLine();

        }
    }
}
