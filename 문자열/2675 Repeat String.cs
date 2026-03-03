using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class _2675_Repeat_String
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            while (T-- != 0)
            {
                string[] S = Console.ReadLine().Split();

                int R = int.Parse(S[0]);

                string ps = "";

                for (int i = 0; i < S[1].Length; i++)
                {
                    for (int j = 0; j < R; j++)
                    {
                        ps += S[1][i];
                    }
                }

                Console.WriteLine(ps);
            }
        }
    }
}
