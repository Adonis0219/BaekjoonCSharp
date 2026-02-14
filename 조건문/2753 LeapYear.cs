using System;
using System.Collections.Generic;
using System.Text;

namespace 조건문
{
    internal class _2753_LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || year % 400 == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}