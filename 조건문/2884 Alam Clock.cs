using System;
using System.Collections.Generic;
using System.Text;

namespace 조건문
{
    internal class Alam_Clock
    {
        static void Main()
        {
            int h, m;

            string[] s = Console.ReadLine().Split();

            h = int.Parse(s[0]);
            m = int.Parse(s[1]);

            if (m >= 45) m -= 45;
            else
            {
                if (h == 0) h = 23;
                else h -= 1;
                m += 15;
            }
            
            Console.WriteLine(h + " " + m);
        }
    }
}
