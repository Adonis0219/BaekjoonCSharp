using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class ReverseBasket
    {
        static int[] basket = new int[101];

        static void Main()
        {
            for (int i = 0; i < basket.Length; i++)
            {
                basket[i] = i;
            }

            string[] nm = Console.ReadLine().Split();
            int N = int.Parse(nm[0]), M = int.Parse(nm[1]);

            for (int x = 0; x < M; x++)
            {
                string[] ij = Console.ReadLine().Split();
                int i = int.Parse(ij[0]), j = int.Parse(ij[1]);

                for (int y = 0; y <= (j - i) / 2; y++)
                {
                    Swap((i + y), (j - y));
                }
            }

            string ps = "";

            for (int x = 1; x <= N; x++) ps += basket[x] + " ";

            Console.WriteLine(ps);
        }

        static void Swap(int a, int b)
        {
            int temp = basket[a];
            basket[a] = basket[b];
            basket[b] = temp;
        }
    }
}
