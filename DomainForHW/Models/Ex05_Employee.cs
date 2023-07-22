using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models
{
    //Реалізуйте клас «Співробітник». Необхідно зберігати у
    //полях класу: ПІБ, дату народження, контактний телефон,
    //робочий email, посаду, опис службових обов’язків.Реалі -
    //зуйте методи класу для введення даних, виведення даних.
    //Реалізуйте доступ до окремих полів через методи класу.
    public class Ex05_Employee
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _dateOfBirth;
        private string _phoneNumber;
        private string _email;
        private string _position;
        private string _jobDescription;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Patronymic
        {
            get { return (_patronymic is null) ? throw new ArgumentNullException("По батькові не задано") : _patronymic; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("По батькові не задано");
                else
                    _patronymic = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер телефону повинен містити 12 символів");
                }
                else
                {
                    long number = Convert.ToInt64(value);
                    _phoneNumber = number.ToString("+## (###) ###-##-##");
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string JobDescription
        {
            get { return _jobDescription; }
            set { _jobDescription = value; }
        }

        public Ex05_Employee() { }

        public Ex05_Employee(string name, string surname, string patronymic, DateTime dateOfBirth, string phoneNumber, string email) : this()
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void InputInfo()
        {
            Console.WriteLine("Введіть Ім'я: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введіть Прізвище: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Введіть По батькові: ");
            Patronymic = Console.ReadLine();
            Console.WriteLine("Введіть дату народження: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Введіть номер телефону: +");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введіть email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Введіть посаду: ");
            Position = Console.ReadLine();
            Console.WriteLine("Введіть опис обов'язків: ");
            JobDescription = Console.ReadLine();
        }
       
        public void ShowInfo()
        {
            Console.WriteLine($"Інформація про співробітника:");
            Console.WriteLine($"ПІБ: {Surname} {Name} {Patronymic}");
            Console.WriteLine($"Дата народження: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Номер телефону: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Опис обов'язків: {JobDescription}");
        }
    }
}
