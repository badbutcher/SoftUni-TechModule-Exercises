namespace _004SieveOfEratosthenes
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] num = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                num[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (num[i])
                {
                    for (int j = i * i; j < num.Length; j += i)
                    {
                        num[j] = false;
                    }
                }
            }

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (num[i])
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }
    }
}