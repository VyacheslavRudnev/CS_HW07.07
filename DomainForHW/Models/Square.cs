using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Square
    {
        public void ShowSquare(int lenght, char ch)
        {
            Console.WriteLine($"Квадрат з довжиною сторони {lenght} з символів {ch}: \n");
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write($"  {ch}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
