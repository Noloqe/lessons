using System;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Мария", "Иванова", "Павловна"));
            Console.WriteLine(GetFullName("Александр", "Кириллов", "Олегович"));
            Console.WriteLine(GetFullName("Зинаида", "Бражникова", "Константиновна"));
            Console.WriteLine(GetFullName("Алеся", "Александрова", "Алексеевна"));
            Console.ReadLine();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}
