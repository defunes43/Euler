using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Defi2
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        public static int Execute()
        {
            const int upperBound = 4000000;
            int fibonacciN_2 = 0;
            int fibonacciN_1 = 1;
            int fibonacciN;

            int result = 0;

            while ((fibonacciN = fibonacciN_2 + fibonacciN_1) < upperBound)
            {
                if(fibonacciN % 2 == 0)
                {
                    result += fibonacciN;
                }
                fibonacciN_2 = fibonacciN_1;
                fibonacciN_1 = fibonacciN;
            }
            return result;
        }
    }
}
