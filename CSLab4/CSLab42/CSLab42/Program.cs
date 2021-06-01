using System;
using System.Runtime.InteropServices;

namespace CSLab42
{
    class Program
    {
        [DllImport("MyDll.dll")]
        public static extern double mPow(double a, double n);
        static void Main(string[] args)
        {
            int a, n;
            Console.Write("Input a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result is: ");
            double result = MyDll.Calculations.mPow(a, n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}