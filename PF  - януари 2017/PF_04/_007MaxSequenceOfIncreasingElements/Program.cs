namespace _007MaxSequenceOfIncreasingElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> longest = new List<int>();
            List<int> currentLongest = new List<int>();

            for (int i = 1; i < input.Length; i++)
            {
                int number = input[i - 1];

                if (number < input[i])
                {
                    if (currentLongest.Count == 0)
                    {
                        currentLongest.Add(number);
                    }

                    currentLongest.Add(input[i]);
                }
                else
                {
                    currentLongest = new List<int>();
                }

                if (currentLongest.Count > longest.Count)
                {
                    longest = new List<int>(currentLongest);
                }
            }

            Console.WriteLine(string.Join(" ", longest));
        }
    }
}