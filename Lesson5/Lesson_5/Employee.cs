using System;

namespace Lesson_5
{
    public class Employee
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public Employee(
            string lastName,
            string name,
            string middleName,
            string jobTitle,
            string email,
            string phone,
            double salary,
            int age)
        {
            LastName = lastName;
            Name = name;
            MiddleName = middleName;
            JobTitle = jobTitle;
            Email = email;
            Phone = phone;
            Salary = salary;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Информация о сотруднике:" + Environment.NewLine +
                              $"ФИО: {LastName} {Name} {MiddleName}" + Environment.NewLine +
                              $"Должность: {JobTitle}" + Environment.NewLine +
                              $"Email: {Email}" + Environment.NewLine +
                              $"Телефон: {Phone}" + Environment.NewLine +
                              $"Зарплата: {Salary}" + Environment.NewLine +
                              $"Возраст: {Age}" + Environment.NewLine);
        }
    }
}
