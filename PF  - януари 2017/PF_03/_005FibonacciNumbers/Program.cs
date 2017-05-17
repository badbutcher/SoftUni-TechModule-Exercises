namespace _005FibonacciNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Fibonacci(input);
        }

        private static void Fibonacci(int input)
        {
            int result = 1;
            int n0 = 0;
            int n1 = 1;

            for (int i = 0; i < input; i++)
            {
                result = n0 + n1;
                n0 = n1;
                n1 = result;
            }

            Console.WriteLine(result);
        }
    }
}