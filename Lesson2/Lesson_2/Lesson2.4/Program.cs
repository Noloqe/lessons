using System;

namespace Lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string store = "ТОРГОВЫЙ ОБЪЕКТ № 1";
            string address = "182113, Россия, Псковская обл, г Великие Луки, ул Прудная, 30";
            string cashier = "Побоев В Д";
            string salePlace = "Развозная торговля №360222020221";
            string buy1 = ("Кофемашина 356134 1шт x 42498");
            string buy2 = ("Доставка 1шт x 698");
            string buy3 = ("Подъём на этаж 1шт x 94");
            long cashDeskRegNumber = 000464927042112;
            long cashDeskFactoryNumber = 032138000060717775;
            long inn = 602510762430;
            DateTime dateTime = new DateTime(2021, 02, 3, 10, 11, 00);
            int shift = 12;
            int receiptNumber = 109;
            double totalAmount = 43290.00;

            Console.WriteLine(store);
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ!");
            Console.WriteLine($"РН ККТ: {cashDeskRegNumber}");
            Console.WriteLine($"ЗН ККТ: {cashDeskFactoryNumber}");
            Console.WriteLine("КАССОВЫЙ ЧЕК/ПРИХОД");
            Console.WriteLine($"ИНН: {inn}");
            Console.WriteLine($"Кассир: {cashier}");
            Console.WriteLine("САЙТ ФНС: www.nalog.ru");
            Console.WriteLine($"АДРЕСС: {address}");
            Console.WriteLine($"МЕСТО РАСЧЕТА: {salePlace}");
            Console.WriteLine(dateTime);
            Console.WriteLine($"СМЕНА: {shift}");
            Console.WriteLine($"ЧЕК: {receiptNumber}\n");
            Console.WriteLine("_____________________________________________________________________\n");
            Console.WriteLine(buy1);
            Console.WriteLine(buy2);
            Console.WriteLine(buy3);
            Console.WriteLine($"\nИТОГ: {totalAmount} \nСУММА БЕЗ НДС {totalAmount} \nПОЛУЧЕНО {totalAmount}");

        }
    }
}
