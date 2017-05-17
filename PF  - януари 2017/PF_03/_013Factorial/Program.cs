namespace _013Factorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Factorial(input);
        }

        private static void Factorial(int input)
        {
            BigInteger result = input;

            for (int i = input - 1; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}