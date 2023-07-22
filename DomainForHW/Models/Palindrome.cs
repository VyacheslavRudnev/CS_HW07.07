using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    //метод, який перевіряє чи є передане число «паліндромом». 
    public class Palindrome
    {
        public bool IsPalindrome(int _number)
        {
            int temp = _number;
            int reverse = 0;
                        
            while (_number > 0)
            {
                int remainder = _number % 10;
                reverse = (reverse * 10) + remainder;
                _number = _number / 10;
            }
            if (temp == reverse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Число є паліндромом ");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Число не є паліндромом ");
                return false;
            }
        }

        
    }
}
