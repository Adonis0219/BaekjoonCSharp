using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class Find_Alphabet
    {
        static void Main()
        {
            int[] al = new int[26];
            string s = Console.ReadLine();

            string ps = "";

            for (char c = 'a'; c <= 'z'; c++)
            {
                // 포함 함수 Contains
                ps += s.IndexOf(c) + " ";
            }

            Console.WriteLine(ps);
        }
    }
}
