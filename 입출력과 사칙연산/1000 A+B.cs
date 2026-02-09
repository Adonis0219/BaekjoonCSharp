namespace 입출력과_사칙연산
{
    internal class AplusB
    {
        static void Main()
        {
            // 입력된 문자열을 공백을 기준으로 자른 후 배열에 저장한다.
            string[] str = Console.ReadLine().Split();

            // 첫번째 숫자 str[0]과 두번째 숫자 str[1]을 int로 변환하여 더하고 출력
            Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
        }
    }
}
