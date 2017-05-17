namespace _004SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();
            string revNumber = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string number = input[i].ToString();

                for (int j = number.Length - 1; j >= 0; j--)
                {
                    revNumber += number[j].ToString();
                }

                numbers.Add(int.Parse(revNumber));
                revNumber = string.Empty;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}