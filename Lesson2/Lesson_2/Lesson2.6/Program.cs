using System;

namespace Lesson2._6
{
    class Program
    {
        [Flags]
        enum Schedule
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000
        }
        static void Main(string[] args)
        {
            Schedule office1 = (Schedule)0b_0011110;
            Schedule office2 = (Schedule)0b_1111111;

            Console.WriteLine($"Режим работы офиса №1: {office1}");
            Console.WriteLine($"Режим работы офиса №2: {office2}");
        }
    }
}
