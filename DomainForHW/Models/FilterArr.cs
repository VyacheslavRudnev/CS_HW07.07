using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FilterArr
    {
        public void Print(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]}  ");
            }
            Console.WriteLine();
        }
        public int[] FilteredArr(int[] _array, int[] _filter)
        {
            int[] _tempArr = new int[_array.Length];
            int k = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                bool _flag = true;
                for (int j = 0; j < _filter.Length; j++)
                {
                    if (_array[i] == _filter[j])
                    {
                       _flag = false;
                        break;
                    }
                }
                if (_flag)
                {
                    _tempArr[k] = _array[i];
                    k++;
                }
            }
            int[] _filteredArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                _filteredArr[i] = _tempArr[i];
            }
            return _filteredArr;
        }
       



    }
}


        