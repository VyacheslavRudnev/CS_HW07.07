using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DomainForHW.Models
{
    public class Shop
    {
        private string _shopName;
        private string _shopAddress;
        private string _shopDescription;
        private string _shopPhoneNumber;
        private string _shopEmailAddress;

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public string ShopAddress
        {
            get { return _shopAddress; }
            set { _shopAddress = value; }
        }
        public string ShopDescription
        {
            get { return _shopDescription; }
            set { _shopDescription = value; }
        }
        public string ShopPhoneNumber
        {
            get { return _shopPhoneNumber; }
            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер телефону повинен містити 12 символів");
                }
                else
                {
                    long number = Convert.ToInt64(value);
                    _shopPhoneNumber = number.ToString("+## (###) ###-##-##");
                }
            }
        }
        public string ShopEmailAddress
        {
            get { return _shopEmailAddress; }
            set { _shopEmailAddress = value; }
        }
        public Shop() { }
        public Shop(string shopName, string shopAddress, string shopDescription, string shopPhoneNumber, string shopEmailAddress)
        {
            ShopName = shopName;
            ShopAddress = shopAddress;
            ShopDescription = shopDescription;
            ShopPhoneNumber = shopPhoneNumber;
            ShopEmailAddress = shopEmailAddress;
        }
        public override string ToString()
        {
            return $"Shop name: {ShopName}\n" +
                   $"Shop address: {ShopAddress}\n" +
                   $"Shop description: {ShopDescription}\n" +
                   $"Shop phone number: {ShopPhoneNumber}\n" +
                   $"Shop email: {ShopEmailAddress}\n";
        }
        public void InputShop()
        {
            Console.WriteLine("Введіть назву магазину: ");
            ShopName = Console.ReadLine();
            Console.WriteLine("Введіть адресу магазину: ");
            ShopAddress = Console.ReadLine();
            Console.WriteLine("Введіть опис магазину: ");
            ShopDescription = Console.ReadLine();
            Console.WriteLine("Введіть номер телефону магазину: + ");
            ShopPhoneNumber = Console.ReadLine();
            Console.WriteLine("Введіть email магазину: ");
            ShopEmailAddress = Console.ReadLine();
        }
        public void PrintShop()
        {
            Console.WriteLine($"\nІнформація про магазин:");
            Console.WriteLine($"Назва магазину: {ShopName}");
            Console.WriteLine($"Адреса магазину: {ShopAddress}");
            Console.WriteLine($"Опис магазину: {ShopDescription}");
            Console.WriteLine($"Номер телефону магазину: {ShopPhoneNumber}");
            Console.WriteLine($"Email магазину: {ShopEmailAddress}");

            
        }
    }
    






}
