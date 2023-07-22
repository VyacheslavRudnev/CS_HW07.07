using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainForHW.Models
{
    public class Magazine
    {
        private string _magazineName;
        private int _mYear;
        private string _mDescription;
        private string _mPhoneNumber;
        private string _mEmail;

        public string MagazineName
        {
            get { return _magazineName; }
            set { _magazineName = value; }
        }
        public int MYear
        {
            get { return _mYear; }
            set { _mYear = value; }
        }
        public string MDescription
        {
            get { return _mDescription; }
            set { _mDescription = value; }
        }
        public string MPhoneNumber
        {
            get { return _mPhoneNumber; }
            set 
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер телефону повинен містити 12 символів");
                }
                else
                {
                    long number = Convert.ToInt64(value);
                    _mPhoneNumber = number.ToString("+## (###) ###-##-##");
                }
            }
        }
        public string MEmail
        {
            get { return _mEmail; }
            set { _mEmail = value; }
        }
        public Magazine() { }
        public Magazine(string magazineName, int mYear, string mDescription, string mPhoneNumber, string mEmail)
        {
            MagazineName = magazineName;
            MYear = mYear;
            MDescription = mDescription;
            MPhoneNumber = mPhoneNumber;
            MEmail = mEmail;
        }
        public override string ToString()
        {
            return $"Magazine name: {MagazineName}\n" +
                   $"Magazine year: {MYear}\n" +
                   $"Magazine description: {MDescription}\n" +
                   $"Magazine phone number: {MPhoneNumber}\n" +
                   $"Magazine email: {MEmail}\n";
        }

        public void SetInfo()
        {
            Console.Write("Вкажіть назву журналу: ");
            MagazineName = Console.ReadLine();
            Console.Write("Вкажіть рік заснування журналу: ");
            MYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть опис журналу: ");
            MDescription = Console.ReadLine();
            Console.Write("Вкажіть контактний номер телефону журналу: + ");
            MPhoneNumber = Console.ReadLine();
            Console.Write("Вкажіть email адресу журналу: ");
            MEmail = Console.ReadLine();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Інформація про журнал: ");
            Console.WriteLine(this);
        }





    }
}
