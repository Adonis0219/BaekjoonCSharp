using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class Print
    {
        static void Main()
        {
            while (true)
            {
                string str = Console.ReadLine();

                Console.WriteLine(str);

                if (string.IsNullOrEmpty(str)) return;
            }
        }
    }
}
