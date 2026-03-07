using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _10998_팰린드롬
    {
        static void Main()
        {
            string s = Console.ReadLine();
            bool isPalin = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - 1 - i])
                {
                    isPalin = true;
                }
                else
                {
                    isPalin = false;
                    break;
                }
            }

            Console.WriteLine(isPalin ? "1" : "0");
        }
    }
}
