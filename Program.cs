using System;
using System.Text;
using Domain.Models;
using DomainForHW.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            //Завдання 1
            //Напишіть метод, який повертає добуток чисел у вказа -
            //ному діапазоні.Межі діапазону передаються як параметри.
            //Console.WriteLine("Pract/Mod03/ex01\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //try
            //{
            //    Console.Write("Введіть початок діапазону: ");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("\nВведіть кінець діапазону: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Ex01_Product product = new Ex01_Product();
            //    Console.WriteLine($"\nДобуток чисел у вказаному діапазоні: {product.GetProduct(a, b)}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Завдання 2
            //Напишіть метод, який перевіряє чи є число числом
            //Фібоначчі.Число передається як параметр.Якщо число
            //просте, потрібно повернути з методу true, інакше — false.
            //Console.WriteLine("Pract/Mod03/ex02\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //try
            //{
            //    Console.Write("Введіть число: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Ex02_Fibonacci fibonacci = new Ex02_Fibonacci();
            //    if (fibonacci.IsFibonacci(num))
            //    {
            //        Console.WriteLine($"\nЧисло {num} є числом Фібоначчі");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nЧисло {num} не є числом Фібоначчі");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Завдання 3
            //Напишіть метод, який сортує масив за зменшенням
            //або зростанням, залежно від вибору користувача.
            //Алгоритм сортування реалізуйте самостійно. На -
            //приклад, може бути реалізоване сортування методом
            //перестановок.
            //Console.WriteLine("Pract/Mod03/ex03\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //try
            //{
            //    Console.WriteLine("Вкажіть розмір масиву: ");
            //    int size = Convert.ToInt32(Console.ReadLine());
            //    int[] arr = new int[size];
            //    Console.WriteLine("Введіть елементи масиву");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"arr[{i}] = ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine("\nВведіть 1, якщо потрібно відсортувати масив за зростанням, або \n\t2, якщо за спаданням");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"\nВивід початкового масиву: ");
            //    Ex03_Sort startArr = new Ex03_Sort();
            //    startArr.Print(arr);

            //    Ex03_Sort sort = new Ex03_Sort();
            //    sort.Sort(arr, choice);
            //    sort.Print(arr);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Завдання 4
            //Створіть клас «Місто». Необхідно зберігати у полях
            //класу: назву міста, назву країни, кількість жителів у місті,
            //телефонний код міста, назву районів міста. Реалізуйте мето-
            //ди класу для введення даних, виведення даних.Реалізуйте
            //доступ до окремих полів через методи класу.

            //Console.WriteLine("Pract/Mod03/ex04\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //try
            //{
            //    Ex04_City city = new Ex04_City();
            //    city.InputInfo();
            //    city.PrintInfo();
            //    Console.WriteLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Завдання 5
            //Реалізуйте клас «Співробітник». Необхідно зберігати у
            //полях класу: ПІБ, дату народження, контактний телефон,
            //робочий email, посаду, опис службових обов’язків.Реалі -
            //зуйте методи класу для введення даних, виведення даних.
            //Реалізуйте доступ до окремих полів через методи класу.

            //Console.WriteLine("Pract/Mod03/ex05\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //try
            //{
            //    Ex05_Employee employee = new Ex05_Employee();
            //    employee.InputInfo();
            //    Console.WriteLine();
            //    employee.ShowInfo();
            //    Console.WriteLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Завдання 6
            //Реалізуйте клас «Літак». Необхідно зберігати у полях
            //класу: назву літака, назву виробника, рік випуску, тип лі -
            //така.Реалізуйте конструктори і методи класу для введення
            //і виведення даних.Реалізуйте доступ до окремих полів
            //через методи класу. Використовуйте механізм наванта -
            //ження методів.

            //Console.WriteLine("Pract/Mod03/ex06\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //var plane = new Plane();
            //plane.Input();
            //Console.WriteLine();
            //plane.ShowInfo();
            //Console.WriteLine();
            //plane.ShowInfo("Ан-22", "Антонов", 1965, "Військовий");
            //Console.WriteLine();
            //plane.ShowInfo("Ан-22", 1965);
            //Console.WriteLine();


            //Завдання 7
            //Реалізуйте клас Матриця». Реалізуйте конструктори і
            //методи класу для введення і виведення даних, підрахунку
            //максимуму і мінімуму.Використовуйте механізм наван -
            //таження методів.

            //Console.WriteLine("Pract/Mod03/ex07\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Matrix matrix = new Matrix(3, 3);
            //matrix.InputElem();
            //Console.WriteLine();
            //matrix.Show();
            //Console.WriteLine();
            //matrix.ShowMaxElem();
            //Console.WriteLine();
            //matrix.ShowMinElem();
            //Console.WriteLine();
            //Matrix matrix1 = new Matrix();
            //matrix1.InputParam();
            //Console.WriteLine();
            //matrix1.Show();
            //Console.WriteLine();
            //matrix1.ShowMaxElem();
            //Console.WriteLine();
            //matrix1.ShowMinElem();
            //Console.WriteLine();

            //Завдання 1
            //Напишіть метод, який відображає квадрат із деякого
            //символу.Метод приймає довжину сторони квадрата як
            //параметр, — символ.

            //Console.WriteLine("HW/Mod03/ex01\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Square square = new Square();
            //Console.Write("Введіть довжину сторони квадрата: ");
            //int lenght = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введіть символ: ");
            //char ch = char.Parse(Console.ReadLine());

            //square.ShowSquare(lenght, ch);
            //Console.WriteLine();

            //Завдання 2
            //Напишіть метод, який перевіряє чи є передане число
            //«паліндромом». Число передається як параметр. Якщо
            //число — паліндром, потрібно повернути з методу true,
            //інакше — false.
            //Паліндром — число, яке однаково читається в обох
            //напрямках(зліва направо та справа наліво).
            //Наприклад:
            //1221 — паліндром;
            //    3443 — паліндром;
            //    7854 — не паліндром.

            //Console.WriteLine("HW/Mod03/ex02\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //try
            //{
            //    Palindrome palindrome = new Palindrome();
            //    Console.Write("Введіть число: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    int digitCount = number.ToString().Length;
            //    if (digitCount % 2 == 0)
            //    {

            //        Console.WriteLine(palindrome.IsPalindrome(number));
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введене число має непарну кількість цифр.");
            //    }
            //}
            //catch (FormatException e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Помилка формату введення! Потрібно вводити число, а не текст!");
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //    Console.ResetColor();
            //}

            //Завдання 3
            //Напишіть метод, який фільтрує масив за переданими
            //параметрами.Метод приймає параметри: оригіналь -
            //ний_масив, масив_з_даними_для_фільтрації.
            //Метод повертає оригінальний масив без елементів,
            //які знаходяться у масиві для фільтрації.
            //Наприклад:
            //1 2 6 - 1 88 7 6 — оригінальний масив
            //6 88 7 — масив для фільтрації
            //1 2 - 1 — результат роботи методу

            //Console.WriteLine("HW/Mod03/ex03\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("Вкажіть розмір масиву: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] Arr = new int[size];
            //Console.WriteLine("Введіть елементи масиву");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"arr[{i}] = ");
            //    Arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"\nВивід початкового масиву: ");
            //FilterArr startArr = new FilterArr();
            //startArr.Print(Arr);

            //Console.WriteLine($"\nВведіть розмір масиву з елементами для фільтрації: ");
            //int sizeElem = Convert.ToInt32(Console.ReadLine());
            //int[] elemArr = new int[sizeElem];
            //Console.WriteLine("Введіть елементи для фільтрації");
            //for (int i = 0; i < sizeElem; i++)
            //{
            //    Console.Write($"arr[{i}] = ");
            //    elemArr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"\nВивід масиву з елементами для фільтрації: ");
            //startArr.Print(elemArr);

            //Console.WriteLine($"\nВивід масиву після фільтрації: ");
            //startArr.Print(startArr.FilteredArr(Arr, elemArr));

            //Завдання 4
            //Створіть клас «Веб - сайт». Необхідно зберігати у
            //полях класу: назву сайту, шлях до сайту, опис сайту,
            //ip - адресу сайту.Реалізуйте методи класу для введення
            //даних, виведення даних.Реалізуйте доступ до окремих
            //полів через методи класу.

            //Console.WriteLine("HW/Mod03/ex04\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Website website = new Website();
            //website.SetInfo();
            //Console.WriteLine();
            //website.ShowInfo();

            //Завдання 5
            //Створіть клас «Журнал». Необхідно зберігати у полях
            //класу: назву журналу, рік заснування, опис журналу,
            //контактний телефон, email.Реалізуйте методи класу для
            //введення даних, виведення даних.Реалізуйте доступ до
            //окремих полів через методи класу.

            //Console.WriteLine("HW/Mod03/ex05\n");
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Magazine magazine = new Magazine();
            //magazine.SetInfo();
            //Console.WriteLine();
            //magazine.ShowInfo();

//Завдання 6
//Створіть клас «Магазин». Необхідно зберігати у полях
//класу: назву магазину, адреса, опис профілю магазину,
//контактний телефон, email.Реалізуйте методи класу для
//введення даних, виведення даних.Реалізуйте доступ до
//окремих полів через методи класу.
           
            Console.WriteLine("HW/Mod03/ex06\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Shop shop = new Shop();
            shop.InputShop();
            shop.PrintShop();




            Console.WriteLine();
            Console.ReadLine();

            








        }





    }
}
