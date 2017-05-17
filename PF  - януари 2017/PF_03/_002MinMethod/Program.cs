namespace _002MinMethod
{
    using System;

    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        private static void GetMax(int a, int b, int c)
        {
            int maxOne = Math.Max(a, b);
            int maxSecond = Math.Max(maxOne, c);
            Console.WriteLine(maxSecond);
        }
    }
}