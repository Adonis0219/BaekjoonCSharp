using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _25206_너의_평점은
    {
        static void Main()
        {
            double total = 0;
            double score_total = 0;

            for (int i = 0; i < 20; i++)
            {
                string subject = Console.ReadLine();
                string[] token = subject.Split();
                string name = token[0];
                double credit = double.Parse(token[1]);
                string score = token[2];

                if (score == "A+")
                {
                    total += credit;
                    score_total += (4.5 * credit);
                }
                else if (score == "A0")
                {
                    total += credit;
                    score_total += (4 * credit);
                }
                else if (score == "B+")
                {
                    total += credit;
                    score_total += (3.5 * credit);
                }
                else if (score == "B0")
                {
                    total += credit;
                    score_total += (3 * credit);
                }
                else if (score == "C+")
                {
                    total += credit;
                    score_total += (2.5 * credit);
                }
                else if (score == "C0")
                {
                    total += credit;
                    score_total += (2.0 * credit);
                }
                else if (score == "D+")
                {
                    total += credit;
                    score_total += (1.5 * credit);
                }
                else if (score == "D0")
                {
                    total += credit;
                    score_total += credit;
                }
                else if (score == "F")
                {
                    total += credit;
                }
            }

            Console.WriteLine(Math.Round(score_total / total, 6));
        }
    }
}
