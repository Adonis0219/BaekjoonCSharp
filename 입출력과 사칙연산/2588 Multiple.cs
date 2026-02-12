using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace 입출력과_사칙연산
{
    internal class _2588_Multiple
    {
        static void Main()
        {
            // (int)char.GetNumericValue(b[0]) b문자열의 자리수의 문자 하나만 가져옴
            string a = ReadLine();
            string b = ReadLine();

            WriteLine(int.Parse(a) * (int)char.GetNumericValue(b[2]));
            WriteLine(int.Parse(a) * (int)char.GetNumericValue(b[1]));
            WriteLine(int.Parse(a) * (int)char.GetNumericValue(b[0]));
            WriteLine(int.Parse(a) * int.Parse(b));
        }
    }
}
