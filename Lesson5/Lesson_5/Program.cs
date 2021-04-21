using System;
using System.IO;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();
        }

        static void Task1()
        {
            Console.WriteLine("Введите данные:");

            string data = Console.ReadLine();

            File.AppendAllText($"file.txt", data + Environment.NewLine);
        }

        static void Task2()
        {
            string fileName = "startup.txt";
            File.AppendAllText(fileName, DateTime.Now.ToString() + Environment.NewLine);
        }

        static void Task3()
        {
            string fileName = "binaryFile.bin";

            Console.WriteLine("Введите значения от 0 до 255 разделяя их пробелами:");
            string inputData = Console.ReadLine();

            string[] splitedData = inputData.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            byte[] byteArray = new byte[splitedData.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                if (byte.TryParse(splitedData[i], out byte parsedByte))
                {
                    byteArray[i] = parsedByte;
                }
                else
                {
                    throw new Exception("Значение содержит ошибку");
                }
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                writer.Write(byteArray);
            }
        }

        static void Task4()
        {
            Employee[] employeeArray = new Employee[5];

            employeeArray[0] = new Employee("Мартынова", "Алеся", "Григорьевна", "Quality Assurance engineer", "Ivanov@q.com", "+7(965)123-45-67", 113000, 35);
            employeeArray[1] = new Employee("Евдакимов", "Владимир", "Олегович", "Systems Analyst", "Evdakimov@q.com", "+7(926)745-32-15", 164000, 48);
            employeeArray[2] = new Employee("Аксенов", "Петр", "Васильевич", "FullStack Developer", "Aksenov@q.com", "+7(916)777-21-16", 173000, 43);
            employeeArray[3] = new Employee("Синицина", "Ольга", "Александровна", "Backend Developer", "Sinicina@q.com", "+7(965)732-18-48", 148000, 41);
            employeeArray[4] = new Employee("Шварц", "Кирилл", "Дмитриевич", "Frontend Developer", "Shvartz@q.com", "+7(962)153-53-25", 141000, 30);

            foreach (Employee employy in employeeArray)
            {
                if (employy.Age > 40)
                {
                    employy.ShowInfo();
                }
            }
        }
    }
}
