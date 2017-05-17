namespace _001MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> currentLongest = new List<int>();
            List<int> longest = new List<int>();
            int counter = 1;
            int maxCounter = 1;
            currentLongest.Add(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    counter++;
                    currentLongest.Add(input[i - 1]);
                }
                else
                {
                    counter = 1;
                    currentLongest.Clear();
                    currentLongest.Add(input[i]);
                }

                if (longest.Count < currentLongest.Count)
                {
                    longest.Clear();
                    maxCounter = counter;
                    longest.AddRange(currentLongest);
                }
            }

            if (maxCounter == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", longest));
            }
        }
    }
}