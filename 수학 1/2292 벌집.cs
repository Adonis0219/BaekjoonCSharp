using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2292_벌집
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            if (N == 1)
                Console.WriteLine(1);
            else
            {
                while (true)
                {
                    int start = 0, gap = 1, answer = 1;

                    if (N >= (6 * start) + 2 && N <= (6 * (start + gap) + 1))
                    {
                        Console.WriteLine(answer + 1);
                        return;
                    }

                    start += gap;
                    gap++;
                    answer++;
                }
            }
        }
    }
}
