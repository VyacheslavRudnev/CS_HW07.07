

namespace Domain.Models
{
    public class Ex01_Product
    {
        public int GetProduct(int _start, int _end)
        {
            int product = 1;
            for (int i = _start; i <= _end; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
