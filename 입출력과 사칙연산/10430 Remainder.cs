using System;
using System.Collections.Generic;
using System.Text;

namespace 입출력과_사칙연산
{
    internal class _10430_Remainder
    {
        static void Main()
        {
            int A, B, C;

            string[] s = Console.ReadLine().Split();

            A = int.Parse(s[0]);
            B = int.Parse(s[1]);
            C = int.Parse(s[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
