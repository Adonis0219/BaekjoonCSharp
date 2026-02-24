using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class Remain
    {
        static void Main()
        {
            int[] remains = new int[42];
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());

                remains[a % 42]++;
            }

            for (int i = 0; i < remains.Length; i++)
            {
                if (remains[i] != 0) count++;
            }

            Console.WriteLine(count); 
        }
    }
}
