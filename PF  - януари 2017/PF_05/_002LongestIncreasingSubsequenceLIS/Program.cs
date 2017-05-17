namespace _002LongestIncreasingSubsequenceLIS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = new List<int>();
            var length = new int[input.Length];
            var prev = new int[input.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }


            while (lastIndex != -1)
            {
                result.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}