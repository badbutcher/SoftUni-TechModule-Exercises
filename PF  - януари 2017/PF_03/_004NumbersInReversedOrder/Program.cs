namespace _004NumbersInReversedOrder
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            ReverseNumber(input);
        }

        private static void ReverseNumber(string input)
        {
            char[] result = input.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);
        }
    }
}