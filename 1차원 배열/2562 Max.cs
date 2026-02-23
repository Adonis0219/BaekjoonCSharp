using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class Max
    {
        static void Main()
        {
            int[] arr = new int[9];

            int max = -1, index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i + 1;
                }
            }

            Console.WriteLine(max + "\n" + index);
        }
    }
}
