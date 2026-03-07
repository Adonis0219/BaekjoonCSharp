using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _2444_Star___7
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = N - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
