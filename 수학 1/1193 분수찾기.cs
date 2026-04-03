using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _1193_분수찾기
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0, sum = 0, idx = 0;

            while (num > count)
            {
                count++;
                sum += count;
            }

            idx = num - (sum - count);

            if (count % 2 == 1)
                Console.WriteLine($"{count - idx + 1}/{idx}");
            else
                Console.WriteLine($"{idx}/{count - idx + 1}");
        }
    }
}
