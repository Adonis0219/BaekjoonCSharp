using System;
using System.Collections.Generic;
using System.Text;

namespace 입출력과_사칙연산
{
    internal class LittleJM
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(long.Parse(s[0]) + long.Parse(s[1]) + long.Parse(s[2]));
        }
    }
}