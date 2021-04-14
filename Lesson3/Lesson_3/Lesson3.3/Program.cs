using System;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение: ");
            string message = Console.ReadLine();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            Console.ReadLine();
        }
    }
}
