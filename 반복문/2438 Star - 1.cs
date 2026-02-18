using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class Star_1
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string s = "";

            for (int i = 0; i < N; i++)
            {
                s = "";
                for (int j = 0; j <= i; j++)
                {
                    s += "*";
                }
                Console.WriteLine(s);
            }
        }
    }
}
