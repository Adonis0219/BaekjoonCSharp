using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class String
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();

                string ps = "" + s[0] + s[s.Length - 1];

                Console.WriteLine(ps);
            }
        }
    }
}
