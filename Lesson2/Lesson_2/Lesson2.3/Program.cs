using System;

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            string inputNumber = Console.ReadLine();
            bool parseResult = int.TryParse(inputNumber, out int number);

            if (parseResult == false)
            {
                Console.WriteLine("Некорректно введено число.");
                return;
            }

            if ((number % 2) == 0)
            {
                Console.WriteLine($"{number} - это чётное число.");
            }
            else
            {
                Console.WriteLine($"{number} - это нечётное число.");
            }

            Console.ReadLine();
        }
    }
}
