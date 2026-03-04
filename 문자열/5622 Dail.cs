using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace 문자열
{
    internal class _5622_Dail
    {
        static void Main()
        {
            string nums = Console.ReadLine();
            int sum = 0;

            foreach (var num in nums)
            {
                switch (num)
                {
                    case <= 'C': sum += 3; break;
                    case <= 'F': sum += 4; break;
                    case <= 'I': sum += 5; break;
                    case <= 'L': sum += 6; break;
                    case <= 'O': sum += 7; break;
                    case <= 'S': sum += 8; break;
                    case <= 'V': sum += 9; break;
                    default:     sum += 10;break;
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}
