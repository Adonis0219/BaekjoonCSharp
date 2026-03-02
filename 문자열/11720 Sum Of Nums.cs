using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class Sum_Of_Nums
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int sum = 0;


            for (int i = 0; i < N; i++)
            {
                sum += s[i] - '0';
            }

            Console.WriteLine(sum);
        }
    }
}
