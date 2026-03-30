using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2720_세탁소_사장_동혁
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int money = int.Parse(Console.ReadLine());

                int qu = money / 25;
                money %= 25;

                int di = money / 10;
                money = money % 10;

                int ni = money / 5;
                money = money % 5;

                Console.WriteLine($"{qu} {di} {ni} {money}");
                // Console.WriteLine("{0} {1} {2} {3}", qu, di, ni, pe);
            }
        }
    }
}
