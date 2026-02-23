using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class PutBall
    {
        static void Main()
        {
            int[] bk = new int[101];
            int N, M;

            string[] t = Console.ReadLine().Split();
            N = int.Parse(t[0]);
            M = int.Parse(t[1]);

            for (int i = 0; i < M; i++)
            {
                int s, f, b;

                string[] t1 = Console.ReadLine().Split();
                s = int.Parse(t1[0]);
                f = int.Parse(t1[1]);
                b = int.Parse(t1[2]);

                for (int j = s; j <= f; j++)
                {
                    bk[j] = b;
                }
            }

            string pS = ""; // print string

            for (int i = 1; i <= N; i++)
            {
                pS += bk[i] + " ";
            }

            Console.WriteLine(pS);
        }
    }
}