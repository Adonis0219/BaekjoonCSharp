using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class Char_String
    {
        static void Main()
        {
            string S = Console.ReadLine();
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(S[i - 1]);
        }
    }
}
