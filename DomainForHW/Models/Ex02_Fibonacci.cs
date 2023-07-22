using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ex02_Fibonacci
    {
        public bool IsFibonacci(int _number)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            while (c < _number)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (c == _number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
