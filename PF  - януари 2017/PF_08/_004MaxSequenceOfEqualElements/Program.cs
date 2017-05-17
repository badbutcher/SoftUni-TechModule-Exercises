namespace _004MaxSequenceOfEqualElements
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

            for (int i = 0; i < input.Length; i++)
            {
                List<int> currentLongest = new List<int>();
                int number = input[i];

                for (int j = i; j < input.Length; j++)
                {
                    if (number == input[j])
                    {
                        currentLongest.Add(number);
                    }
                    else
                    {
                        break;
                    }
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