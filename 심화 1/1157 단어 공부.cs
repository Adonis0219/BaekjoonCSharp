using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class 단어_공부
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int[] alpha = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a') alpha[s[i] - 'a']++;
                else alpha[s[i] - 'A']++;
            }

            int max = -1;
            char ans = '\0';

            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] > max)
                {
                    max = alpha[i];
                    ans = (char)('A' + i);
                }
                else if (alpha[i] == max)
                {
                    ans = '?';
                }
            }

            Console.WriteLine(ans);
        }
    }
}
