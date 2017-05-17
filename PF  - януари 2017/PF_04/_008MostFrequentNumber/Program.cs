namespace _008MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> hold = new Dictionary<int, int>();
            int topKey = 0;
            int topValue = 0;

            foreach (var item in input)
            {
                if (!hold.ContainsKey(item))
                {
                    hold.Add(item, 1);
                }
                else
                {
                    hold[item]++;
                }
            }

            foreach (var item in hold)
            {
                if (item.Value > topValue)
                {
                    topValue = item.Value;
                    topKey = item.Key;
                }
            }

            Console.WriteLine(topKey);
        }
    }
}