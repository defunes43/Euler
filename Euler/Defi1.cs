using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Defi1
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        public static int Execute()
        {
            const int upperBound = 1000;
            List<int> validDividers = new List<int> { 3, 5 };
            List<int> multiples = new List<int>();

            int currentMultiple;

            foreach (int divider in validDividers)
            {
                currentMultiple = 0;
                while (currentMultiple < upperBound - divider)
                {
                    currentMultiple += divider;
                    multiples.Add(currentMultiple);
                }
            }
            return multiples.Distinct().Sum();
        }

        static int GetNumberOfMultiples(int divider, int upperBound)
        {
            return upperBound / divider;
        }
    }
}
