namespace _007PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", FindPrimesInRange(start, end)));
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {
            var result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (i != 0)
                {
                    if (IsPrime(i))
                    {
                        result.Add(i);
                    }
                }
            }

            return result;
        }

        private static bool IsPrime(long n)
        {
            if (n == 1)
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