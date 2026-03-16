namespace _2차원_배열
{
    internal class _10798_세로읽기
    {
        static void Main()
        {
            string sentence = "";
            char[,] chars = new char[5, 15];

            for (int i = 0; i < 5; i++)
            {
                sentence = Console.ReadLine();

                for (int j = 0; j < sentence.Length; j++)
                {
                    chars[i, j] = sentence[j];
                }
            }

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (chars[j, i] == '\0')
                        continue;

                    Console.Write(chars[j, i]);
                }
            }
        }
    }
}
