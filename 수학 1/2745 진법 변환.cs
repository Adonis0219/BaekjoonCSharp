using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2745_진법_변환
    {
        static void Main()
        {
            string[] token = Console.ReadLine().Split();

            string N = token[0];
            int B = int.Parse(token[1]);
            double result = 0;

            for (int i = N.Length - 1 ; i >= 0; i--)
            {
                int digit = 0;
                if (char.IsDigit(N[i]))
                {
                    digit = int.Parse(N[i].ToString());
                }
                else
                {
                    digit = (int)N[i] - 55;
                }
                result += Math.Pow(B, N.Length - 1 - i) * digit;  
            }

            Console.WriteLine(result.ToString());
        }
    }
}
