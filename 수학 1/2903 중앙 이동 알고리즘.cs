using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2903_중앙_이동_알고리즘
    {
        static void Main()
        {
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine((2 * Math.Pow(2, m - 1) + 1) * (2 * Math.Pow(2, m - 1) + 1));
        }
    }
}
