using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class CodingIsPhysical
    {
        static void Main()
        {
            string printS = "";

            int N = int.Parse(Console.ReadLine()) / 4;

            for (int i = 0; i < N; i++)
            {
                printS += "long ";
            }

            Console.WriteLine(printS + "int");
        }
    }
}
