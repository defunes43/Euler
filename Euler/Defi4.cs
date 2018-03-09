using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Defi4
    {
        public static long Execute()
        {
            const int digits = 3;
            List<long> allProducts = Helpers.GetAllProductsOfNumberWithDigits(digits);
            foreach (long product in allProducts.Distinct().OrderByDescending(p => p))
            {
                if (Helpers.IsPalindrome(product))
                {
                    return product;
                }
            }
            return -1;
        }

        
    }
}
