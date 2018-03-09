using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Defi3
    {
        //What is the largest prime factor of the number 600851475143 ?
        public static long Execute()
        {
            const long number = 600851475143;
            return PrimeHelper.GetLargestPrimeFactor(number);
        }
    }
}
