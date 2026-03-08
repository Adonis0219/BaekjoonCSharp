using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _2941_크로아티아_알파벳
    {

        static void Main()
        {
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'c')
                {
                    if (i + 1 < s.Length && (s[i + 1] == '=' || s[i + 1] == '-'))
                    {
                        i++;
                    }
                }
                else if (s[i] == 'd')
                {
                    if (i + 2 < s.Length && (s[i + 1] == 'z' && s[i + 2] == '='))
                    {
                        i += 2;
                    }
                    else if (i + 1 < s.Length && s[i + 1] == '-')
                    {
                        i++;
                    }
                }
                else if (s[i] == 'l' || s[i] == 'n')
                {
                    if (i + 1 < s.Length && s[i + 1] == 'j')
                    {
                        i++;
                    }
                }
                else if (s[i] == 's' || s[i] == 'z')
                {
                    if (i + 1 < s.Length && s[i + 1] == '=')
                    {
                        i++;
                    }
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
