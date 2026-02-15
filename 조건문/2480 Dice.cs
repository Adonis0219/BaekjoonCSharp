using System;
using System.Collections.Generic;
using System.Text;

namespace 조건문
{
    internal class _2480_Dice
    {
        static void Main()
        {
            int d1, d2, d3, price;

            string[] s = Console.ReadLine().Split();

            d1 = int.Parse(s[0]);
            d2 = int.Parse(s[1]);
            d3 = int.Parse(s[2]);

            // 1. 같은 눈이 3개일 때
            if (d1 == d2 && d2 == d3)
            {
                price = 10000 + d1 * 1000;
            }
            // 2. 같은 눈이 2개일 때
            else if (d1 == d2 || d1 == d3)
            {
                price = 1000 + d1 * 100;
            }
            else if (d2 == d3)
            {
                price = 1000 + d2 * 100;
            }
            // 같은 눈이 없을 때
            else
            {
                int pD = d1;

                if (pD < d2) pD = d2;
                if (pD < d3) pD = d3;

                price = pD * 100;
            }

            Console.WriteLine(price);
        }
    }
}
