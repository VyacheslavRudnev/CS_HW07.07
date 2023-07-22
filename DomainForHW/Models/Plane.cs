using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Models
{
    public class Plane
    {
        private string _planeName;
        private string _planeManufacturer;
        private int _planeYearOfProdactoin;
        private string _planeType;
        private int _planeCapacity;
        private int _planeRange;
        private int _planeFuelConsumption;
        public string PlaneName
        {
            get { return (_planeName is null) ? throw new ArgumentNullException("PlaneName is null") : _planeName; }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("PlaneName is null");
                else if (value.Length < 2)
                    throw new ArgumentException("PlaneName must be at least 2 characters!");
                else
                    _planeName = value;
            }
        }
        public string PlaneManufacturer
        {
            get { return _planeManufacturer; }
            set { _planeManufacturer = value; }
        }
        public int PlaneYearOfProdactoin
        {
            get { return _planeYearOfProdactoin; }
            set { _planeYearOfProdactoin = value; }
        }
        public string PlaneType
        {
            get { return _planeType; }
            set { _planeType = value; }
        }
        public Plane() { }
        public Plane(string _planeName, string _planeManufacturer, int _planeYearOfProdactoin, string _planeType)
        {
            PlaneName = _planeName;
            PlaneManufacturer = _planeManufacturer;
            PlaneYearOfProdactoin = _planeYearOfProdactoin;
            PlaneType = _planeType;
        }
        public Plane(string _planeName, int _planeYearOfProdactoin):this()
        {
            PlaneName = _planeName;
            PlaneYearOfProdactoin = _planeYearOfProdactoin;
        }
        public override string ToString()
        {
            return 
                $"PlaneName: {PlaneName}\n" +
                $"PlaneManufacturer: {PlaneManufacturer}\n" +
                $"PlaneYearOfProdactoin: {PlaneYearOfProdactoin}\n" +
                $"PlaneType: {PlaneType}\n";
        }
        public void Input()
        {
            Console.WriteLine("Вкажіть назву літака: ");
            PlaneName = Console.ReadLine();
            Console.WriteLine("Вкажіть назву виробника: ");
            PlaneManufacturer = Console.ReadLine();
            Console.WriteLine("Вкажіть рік виготовлення літака: ");
            PlaneYearOfProdactoin = int.Parse(Console.ReadLine());
            Console.WriteLine("Вкажіть тип літака: ");
            PlaneType = Console.ReadLine();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nІнформація про повітряне судно:");
            Console.WriteLine($"Назва: {PlaneName}");
            Console.WriteLine($"Компанія виробник: {PlaneManufacturer}");
            Console.WriteLine($"Рік виготовлення: {PlaneYearOfProdactoin}");
            Console.WriteLine($"Тип літака: {PlaneType}");
        }

        public void ShowInfo(string _planeName, string _planeManufacturer, int _planeYearOfProdactoin, string _planeType)
        {
            Console.WriteLine($"\nІнформація про повітряне судно:");
            Console.WriteLine($"Назва: {_planeName}");
            Console.WriteLine($"Компанія виробник: {_planeManufacturer}");
            Console.WriteLine($"Рік виготовлення: {_planeYearOfProdactoin}");
            Console.WriteLine($"Тип літака: {_planeType}");
        }

        public void ShowInfo(string _planeName, int _planeYearOfProdactoin)
        {
            Console.WriteLine($"\nІнформація про повітряне судно:");
            Console.WriteLine($"Назва: {_planeName}");
            Console.WriteLine($"Рік виготовлення: {_planeYearOfProdactoin}");
        }



    }
}
