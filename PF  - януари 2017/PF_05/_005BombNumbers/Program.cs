namespace _005BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombChar = bomb[0];
            int bombPower = bomb[1];

            int leftEnd = 0;
            int rightEnd = input.Count;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Equals(bombChar))
                {
                    int bombIndex = input.FindIndex(a => a == input[i]);

                    for (int j = bombIndex; j <= bombIndex + bombPower; j++)
                    {
                        if (j <= rightEnd)
                        {
                            input[j] = 0;
                        }
                        else
                        {
                            break;
                        }
                    }

                    for (int k = bombIndex - 1; k >= bombIndex - bombPower; k--)
                    {
                        if (k >= leftEnd)
                        {
                            input[k] = 0;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(input.Sum());
        }
    }
}