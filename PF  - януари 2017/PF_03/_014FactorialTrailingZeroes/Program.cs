namespace _014FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger number = Factorial(input);

            int zeros = GetZeros(number);

            Console.WriteLine(zeros);
        }

        private static int GetZeros(BigInteger number)
        {
            var num = number.ToString();
            int counter = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

        private static BigInteger Factorial(int input)
        {
            BigInteger result = input;

            for (int i = input - 1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}