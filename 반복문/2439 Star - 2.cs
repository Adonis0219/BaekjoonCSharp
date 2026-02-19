using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class Star_2
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string s = "";

                for (int j = N; j > i; j--)
                {
                    s += " ";
                }

                for (int j = 0; j < i; j++)
                {
                    s += "*";
                }

                Console.WriteLine(s);
            }
        }
    }
}
