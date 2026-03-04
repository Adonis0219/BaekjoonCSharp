using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class _2908_SangSoo
    {
        static void Main()
        {
            // 숫자 2개 입력 받기
            string[] s = Console.ReadLine().Split();

            // 숫자 뒤집기
            int A = int.Parse(ReverseWord(s[0]));
            int B = int.Parse(ReverseWord(s[1]));

            // 숫자 비교 후 출력
            string ps = (A > B ? A : B) + "";

            Console.WriteLine(ps);
        }

        static string ReverseWord(string _word)
        {
            char[] word = _word.ToCharArray();

            char temp = word[0];
            word[0] = word[2];
            word[2] = temp;

            string revWord = new string(word);

            return revWord;
        }
    }
}
