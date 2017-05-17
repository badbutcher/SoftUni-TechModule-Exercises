namespace _015FastPrimeCheckerRefactor
{
    using System;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                bool checkPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {checkPrime}");
            }
        }
    }
}