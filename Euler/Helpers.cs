using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Helpers
    {
        public static List<long> GetAllProductsOfNumberWithDigits(int digits)
        {
            double upperBound = Math.Pow(10, digits);
            List<long> resultList = new List<long>();

            for (long firstFactor = 1; firstFactor < upperBound; firstFactor++)
            {
                for (long secondFactor = 1; secondFactor < upperBound; secondFactor++)
                {
                    resultList.Add(firstFactor * secondFactor);
                }
            }
            return resultList;
        }
        public static bool IsPalindrome(long number)
        {
            if(number.ToString() != new String(number.ToString().Reverse().ToArray()))
            {
                return false;
            }
            return true;
        }
    }
}
