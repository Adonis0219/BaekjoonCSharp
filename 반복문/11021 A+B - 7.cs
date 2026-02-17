using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class AplusB_7
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                string[] s = Console.ReadLine().Split();

                int sum = int.Parse(s[0]) + int.Parse(s[1]);

                Console.WriteLine("Case #" + i + ": " + sum);
            }
        }
    }
}
