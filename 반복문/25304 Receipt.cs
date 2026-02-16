using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class Receipt
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split();

                X -= int.Parse(s[0]) * int.Parse(s[1]);                
            }

            Console.WriteLine((X == 0) ? "Yes" : "No");
        }
    }
}
