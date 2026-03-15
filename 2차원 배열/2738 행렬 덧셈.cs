using System;
using System.Collections.Generic;
using System.Text;

namespace _2차원_배열
{
    internal class _2738_행렬_덧셈
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] token = s.Split();
            int N = int.Parse(token[0]);
            int M = int.Parse(token[1]);
            int[,] A = new int[N, M];
            int[,] B = new int[N, M];

            // 배열 A 저장
            for (int i = 0; i < N; i++)
            {
                string[] A_token = Console.ReadLine().Split();

                for (int j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(A_token[j]);
                }
            }

            // 배열 B 저장
            for (int i = 0; i < N; i++)
            {
                string[] B_token = Console.ReadLine().Split();

                for (int j = 0; j < M; j++)
                {
                    B[i, j] = int.Parse(B_token[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + B[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
