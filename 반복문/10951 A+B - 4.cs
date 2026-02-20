using System;
using System.Collections.Generic;
using System.Text;

namespace 반복문
{
    internal class AplusB_4
    {
        static void Main()
        {
            while (true)
            {
                var s = Console.ReadLine();

                if (s == null) break;

                var nums = s.Split();

                Console.WriteLine(int.Parse(nums[0]) + int.Parse(nums[1]));
            }           
        }
    }
}
