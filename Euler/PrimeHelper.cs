using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public static class PrimeHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static long GetLargestPrimeFactor(long number)
        {
            long primeFactor = 1;
            long remainder = number;

            while(remainder > 1)
            {
                primeFactor += 1;
                if (remainder % primeFactor == 0)
                {
                    remainder /= primeFactor;
                }            
            }
            return primeFactor;
        }
    }
}
