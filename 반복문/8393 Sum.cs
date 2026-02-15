using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class Sum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int pN = 0;

            for (int i = 1; i <= n; i++)
            {
                pN += i;
            }

            Console.WriteLine(pN);
        }
    }
}
