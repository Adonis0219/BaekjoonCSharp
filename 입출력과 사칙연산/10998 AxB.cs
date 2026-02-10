namespace 입출력과_사칙연산
{
    internal class AxB
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
        }
    }
}
