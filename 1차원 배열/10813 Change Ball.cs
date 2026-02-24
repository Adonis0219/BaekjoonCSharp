using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class ChangeBall
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            int N = int.Parse(s[0]), M = int.Parse(s[1]);
            int[] arr = new int[N + 1];

            for (int i = 1; i <= N; i++)
            {
                // 인덱스 0 -> 1번 바구니
                arr[i] = i;
            }

            for (int a = 0; a < M; a++)
            {
                string[] s1 = Console.ReadLine().Split();
                int i = int.Parse(s1[0]), j = int.Parse(s1[1]);


                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            string printS = "";

            for (int i = 1; i <= N; i++)
            {
                printS += arr[i] + " ";
            }

            Console.WriteLine(printS);
        }
    }
}
