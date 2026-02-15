using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class AplusB_3
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] s = Console.ReadLine().Split();

                Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            }
        }
    }
}
