using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class Min_Max
    {
        static void Main()
        {
            int N, min = 1000000, max = -1000000;

            N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();

            int[] nums = Array.ConvertAll(s, int.Parse);

            for (int i = 0; i < N; i++)
            {
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }

            Console.WriteLine(min  + " " + max);
        }
    }
}
