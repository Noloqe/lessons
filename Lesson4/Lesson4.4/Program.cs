using System;

namespace Lesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("число Фибоначчи: " + Fibonacci(number));
            Console.ReadLine();
        }

        static int Fibonacci(int number)
        {
            return Fibonacci(number,out _);
        }

        static int Fibonacci(int number, out int fibonacci)
        {
            fibonacci = 0;
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                fibonacci = Fibonacci(number - 1, out int fibonacciNext);
                return fibonacci + fibonacciNext;
            }
        }
    }
}
