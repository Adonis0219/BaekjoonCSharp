using System;
using System.Collections.Generic;
using System.Text;

namespace 수학_1
{
    internal class _2869_달팽이
    {
        static void Main()
        {
            string[] token = Console.ReadLine().Split();

            int A = int.Parse(token[0]);
            int B = int.Parse(token[1]);
            int V = int.Parse(token[2]);

            int day = 1;

            while (true)
            {
                V -= A;
                
                if (V <= 0)
                {
                    Console.WriteLine(day);
                    return;
                }

                V += B;

                day++;
            }
        }
    }
}
