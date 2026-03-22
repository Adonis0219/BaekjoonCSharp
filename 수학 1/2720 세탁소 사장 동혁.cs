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
                // 잔돈
                int money = int.Parse(Console.ReadLine());

                // 25단위 개수
                int qu = money / 25;
                // 25 단위로 나눈 나머지를 구함
                money %= 25;
                // 위의 과정을 단위 별로 반복
                int dime = money / 10;
                money %= 10;

                int nickel = money / 5;
                money %= 5;

                int penny = money;

                Console.WriteLine("{0} {1} {2} {3}", qu, dime, nickel, penny);
            }
        }
    }
}
