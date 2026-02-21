using System;
using System.Collections.Generic;
using System.Text;

namespace _1차원_배열
{
    internal class LessThanX
    {
        static void Main()
        {
            var temp = Console.ReadLine().Split();
            int N = int.Parse(temp[0]), X = int.Parse(temp[1]); 
            string[] s = Console.ReadLine().Split();

            string printS = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (int.Parse(s[i]) < X) printS += s[i] + " ";
            }

            Console.WriteLine(printS);
        }
    }
}
