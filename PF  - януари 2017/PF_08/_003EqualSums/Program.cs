namespace _003EqualSums
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < input.Length; i++)
            {
                int countLeft = 0;
                int countRight = 0;

                for (int j = i + 1; j < input.Length; j++)
                {
                    countRight += input[j];
                }

                for (int j = 0; j < i; j++)
                {
                    countLeft += input[j];
                }

                if (countLeft == countRight)
                {
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}