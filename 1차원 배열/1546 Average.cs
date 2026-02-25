using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class Average
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            float M = 0;

            string[] s = Console.ReadLine().Split();
            float[] score = Array.ConvertAll(s, float.Parse);

            for (int i = 0; i < N; i++)
            {               
                if (score[i] > M) M = score[i];
            }

            float total = 0;

            for (int i = 0; i < N; i++)
            {
                score[i] = score[i] / M * 100;
                total += score[i];
            }

            Console.WriteLine(total / N);
        }
    }
}
