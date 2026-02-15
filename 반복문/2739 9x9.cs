namespace 반복문
{
    internal class Program
    {
        static void Main()
        {
            int dan = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(dan + " * " + i + " = " + i * dan);
            }
        }
    }
}
