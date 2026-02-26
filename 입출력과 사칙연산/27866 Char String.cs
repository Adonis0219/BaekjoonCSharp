using System;
using System.Collections.Generic;
using System.Text;

namespace 입출력과_사칙연산
{
    internal class Char_String
    {
        static void Main(string[] args)
        {

            var str = Console.ReadLine()!;
            var idx = int.Parse(Console.ReadLine()!);

            Console.WriteLine(str[idx - 1]);

        }
    }
}
