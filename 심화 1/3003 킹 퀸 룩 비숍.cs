using System;
using System.Collections.Generic;
using System.Text;

namespace 심화_1
{
    internal class _3003_킹_퀸_룩_비숍
    {
        /* 문제: 백준 3003 - 킹, 퀸, 룩, 비숍, 나이트, 폰

        패턴:
        배열 매핑 + 반복문

        아이디어:
        정답 체스 배열 선언
        입력 배열 생성
        두 배열의 차이를 출력

        배운 점:
        Console.Write vs Console.WriteLine
        */

        static void Main()
        {
            int[] chess = { 1, 1, 2, 2, 2, 8 };

            string[] S = Console.ReadLine().Split();

            int[] dChess = Array.ConvertAll(S, int.Parse);

            #region 기존 방식
            /*string ps = "";

            for (int i = 0; i < chess.Length; i++)
            {
                ps += (chess[i] - dChess[i]) + " ";
            }
            
            Console.WriteLine(ps);*/
            #endregion

            for (int i = 0; i < dChess.Length; i++)
                Console.Write(chess[i] - dChess[i] + " ");
        }
    }
}
