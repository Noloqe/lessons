using System;

namespace Lesson2._2
{
    class Program
    {
        [Flags]
        enum months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите порядковый номер текщего месяца: ");
            int currentMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Текущий месяц: {(months)currentMonth}");

            if (currentMonth == 12 || currentMonth == 1 || currentMonth == 2)
            {
                Console.WriteLine("Введите среднюю температуру за месяц: ");
                string addedTemp = Console.ReadLine().Replace('.', ',');
                bool TempParseResult = float.TryParse(addedTemp, out float averageTemp);

                if (TempParseResult == false)
                {
                    Console.WriteLine("Неккоректно введена средняя температура за месяц.");
                    return;
                }

                if ((currentMonth == 12 || currentMonth == 1 || currentMonth == 2) && averageTemp > 0)
                {
                    Console.WriteLine("Дождливая зима!");
                }
            }
            else
            {
                Console.ReadLine();
            }


        }
    }
}
