using System;
using System.Collections.Generic;
using System.Text;

namespace 문자열
{
    internal class ASCII
    {
        static void Main()
        {
            char c = Convert.ToChar(Console.ReadLine());
            int ascii = Convert.ToInt32(c);
            
            Console.WriteLine(ascii);
        }
    }
}
