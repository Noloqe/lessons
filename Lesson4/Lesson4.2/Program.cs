using System;

namespace Lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            Console.Write("Cумма чисел = " + Sum(Console.ReadLine()));
            Console.ReadLine();
        }

        static int Sum(string numbers)
        {
            int sum = 0;
            string number = string.Empty;
            for (int i = 0; i <= numbers.Length; i++)
            {
                if (i == numbers.Length || numbers[i] == ' ')
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        sum += Convert.ToInt32(number);
                        number = string.Empty;
                    }
                }
                else
                {
                    number += numbers[i];
                }
            }
            return sum;
        }
    }
}
