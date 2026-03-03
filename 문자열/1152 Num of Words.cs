using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class Num_of_Words
    {
        static void Main()
        {
            string[] S = Console.ReadLine().Trim().Split();
            int count = 0;

            // 공백만 입력 시 문자열의 길이는 1이 된다 ("")
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != "")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}