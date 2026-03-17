using System;
using System.Collections.Generic;
using System.Text;

namespace _2차원_배열
{
    internal class _2563_색종이
    {
        static void Main()
        {
            int[,] a = new int[100, 100];
            int count = int.Parse(Console.ReadLine()), area = 0;

            while (count-- != 0)
            {
                string[] token = Console.ReadLine().Split();

                int x = int.Parse(token[0]), y = int.Parse(token[1]);

                for (int i = x; i < x + 10; i++)
                    for (int j = y; j < y + 10; j++)
                        a[i, j]++;
            }

            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                    if (a[i, j] != 0)
                        area++;

            Console.WriteLine(area);
        }
    }
}
