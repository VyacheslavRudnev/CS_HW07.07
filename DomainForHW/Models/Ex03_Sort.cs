using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ex03_Sort
    {
        public void Print(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]} \t");
            }
            Console.WriteLine();
        }
        public void Sort(int[] _array, int _choice)
        {
            int temp;
            if (_choice == 1)
            {
                Console.WriteLine("\nВідсортований масив за зростанням: ");
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    for (int j = i + 1; j < _array.Length; j++)
                    {
                        if (_array[i] > _array[j])
                        {
                            temp = _array[i];
                            _array[i] = _array[j];
                            _array[j] = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nВідсортований масив за спаданням: ");
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    for (int j = i + 1; j < _array.Length; j++)
                    {
                        if (_array[i] < _array[j])
                        {
                            temp = _array[i];
                            _array[i] = _array[j];
                            _array[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
