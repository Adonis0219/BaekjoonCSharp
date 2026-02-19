using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class AplusB_5
    {
        static void Main()
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split();

                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                if (a == 0 && b == 0) break;

                Console.WriteLine(a + b);
            }
        }
    }
}
