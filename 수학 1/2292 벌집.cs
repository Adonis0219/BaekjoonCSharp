using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2292_벌집
    {
        static void Main()
        {
            // 문제 조건 범위 고려
            double n = double.Parse(Console.ReadLine());

            if (n == 1) Console.WriteLine(1);
            else
            {
                int start = 0, gap = 1, answer = 1;

                while (true)
                {
                    if (n >= (6 * start + 2) && n <= (6 * (start + gap) + 1))
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
