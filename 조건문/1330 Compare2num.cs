using System;
using System.Collections.Generic;
using System.Text;

namespace 조건문
{
    internal class _1330_Compare2num
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if (a > b) Console.WriteLine(">");
            else if (a < b) Console.WriteLine("<");
            else Console.WriteLine("==");
        }
    }
}
