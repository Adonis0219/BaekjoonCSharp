namespace 입출력과_사칙연산
{
    internal class AdivB
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));
        }
    }
}
