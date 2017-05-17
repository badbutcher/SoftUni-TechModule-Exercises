namespace _001MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers.Add(input[i], 0);
                }

                numbers[input[i]]++;
            }

            int numberChar = 0;
            int longest = 0;
            int currentLongest = 0;

            foreach (var item in numbers)
            {
                currentLongest = item.Value;

                if (currentLongest > longest)
                {
                    longest = currentLongest;
                    numberChar = item.Key;
                }
            }

            Console.WriteLine(numberChar);
        }
    }
}