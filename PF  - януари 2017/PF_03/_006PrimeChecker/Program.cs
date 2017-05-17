namespace _006PrimeChecker
{
    using System;

    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(long n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            var check = Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= check; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}