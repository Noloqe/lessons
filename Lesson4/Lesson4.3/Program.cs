using System;

namespace Lesson4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int month;
            do
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            } while (month < 1 || month > 12);
            Seasons season = NameSeason(month);
            Console.WriteLine("Время года: " + NameSeasonRu(season));
            Console.ReadLine();
        }

        static Seasons NameSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default: throw new Exception("Этот месяц не существует.");
            }
        }

        static string NameSeasonRu(Seasons season)
        {
            string seasonRu = string.Empty;
            switch (season)
            {
                case Seasons.Winter:
                    seasonRu = "зима";
                    break;
                case Seasons.Spring:
                    seasonRu = "весна";
                    break;
                case Seasons.Summer:
                    seasonRu = "лето";
                    break;
                case Seasons.Autumn:
                    seasonRu = "осень";
                    break;
            }
            return seasonRu;
        }
    }
}
