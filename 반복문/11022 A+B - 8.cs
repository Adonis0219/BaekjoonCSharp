using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class AplusB_8
    {
         static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                string[] s = Console.ReadLine().Split();

                int a = int.Parse(s[0]), b = int.Parse(s[1]);
                int sum = a + b;

                Console.WriteLine("Case #" + i + ": " + a + " + " + b + " = " + sum);
            }
        }
    }
}
