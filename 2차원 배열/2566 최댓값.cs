using System;
using System.Collections.Generic;
using System.Text;

namespace _2차원_배열
{
    internal class _2566_최댓값
    {
        static void Main()
        {
            int[,] A = new int[9, 9];
            int max = int.MinValue, max_i = -1, max_j = -1;

            for (int i = 0; i < 9; i++)
            {
                string[] token = Console.ReadLine().Split();

                for (int j = 0; j < 9; j++)
                {
                    int temp = int.Parse(token[j]);
                    A[i, j] = temp;

                    if (temp > max)
                    {
                        max = temp;
                        // 0번부터가 아닌 1번부터
                        max_i = i + 1;
                        max_j = j + 1;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(max_i + " " + max_j);
        }
    }
}
