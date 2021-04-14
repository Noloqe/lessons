using System;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Введите имя контакта: ");
                string contact = Console.ReadLine();
                array[i, 0] = contact;
                Console.WriteLine("Введите номер телефона: ");
                string number = Console.ReadLine();
                array[i, 1] = number;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
