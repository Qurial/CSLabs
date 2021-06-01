using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    unsafe public static class Calculations
    {
        public static double mPow(double val, double n)
        {
            double result = 1;
            double* x = &result;
            for (int i = 0; i < n; i++)
            {
                *x *= val;
            }
            return result;
        }
    }
}
