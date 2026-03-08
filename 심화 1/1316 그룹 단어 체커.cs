using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _1316_그룹_단어_체커
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine()), count = 0;

            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();

                bool[] visited = new bool[26];
                bool isGroup = true;

                for (int j = 0; j < s.Length; j++)
                {
                    int idx = s[j] - 'a';

                    if (!visited[idx])
                    {
                        visited[idx] = true;
                    }
                    else if (s[j - 1] != s[j])
                    {
                        isGroup = false;
                        break;
                    }
                }

                if (isGroup)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
