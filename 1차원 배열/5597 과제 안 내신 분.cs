using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class _5597_과제_안_내신_분
    {
        static void Main()
        {
            int[] n = new int[31];  // 인덱스 0번을 제외한 30명 출석부
            // C#은 배열 초기화 불필요

            // 28번 반복
            for (int i = 0; i < 28; i++)
            {
                int st = int.Parse(Console.ReadLine());

                n[st] = 1;
            }

            // 1번부터 30번까지 검사
            for (int i = 1; i <= 30; i++)
            {
                if (n[i] == 0) Console.WriteLine(i);
            }
        }
    }
}
