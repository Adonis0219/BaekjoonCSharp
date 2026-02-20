using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class Counting
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            string[] s = Console.ReadLine().Split();

            int v = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                if (v == int.Parse(s[i])) count++;
            }

            Console.WriteLine(count);
        }
    }
}
