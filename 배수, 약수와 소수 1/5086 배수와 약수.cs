using System;
using System.Collections.Generic;
using System.Text;

namespace 배수__약수와_소수_1
{
    internal class 배수와_약수
    {
        static void Main()
        {
            while (true)
            {
                string[] token = Console.ReadLine().Split();
                int a = int.Parse(token[0]), b = int.Parse(token[1]);

                if (a == 0 && b == 0) break;

                if (a % b == 0) Console.WriteLine("multiple");
                else if (b % a == 0) Console.WriteLine("factor");
                else Console.WriteLine("neither");            
            }
        }
    }
}
