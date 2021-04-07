using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную суточную температуру: ");
            string minTempStr = Console.ReadLine();
            string preparedMinTempStr = minTempStr.Replace('.', ',');
            bool minTempParseResult = float.TryParse(preparedMinTempStr, out float minTemp);

            if (minTempParseResult == false)
            {
                Console.WriteLine("Неккоректно введена суточная температура.");
                return;
            }
            
            Console.WriteLine("Введите максимальную суточную температуру: ");
            string maxTempStr = Console.ReadLine();
            string preparedMaxTempStr = maxTempStr.Replace('.', ',');
            bool maxTempParseResult = float.TryParse(preparedMaxTempStr, out float maxTemp);

            if (maxTempParseResult == false)
            {
                Console.WriteLine("Неккоректно введена суточная температура.");
                return;
            }

            float averageTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"\nСреднесуточная температура: {averageTemp} градусов ");
            
            Console.ReadLine();
        }
    }
}
