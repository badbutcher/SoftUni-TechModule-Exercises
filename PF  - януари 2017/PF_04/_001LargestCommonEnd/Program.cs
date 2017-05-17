namespace _001LargestCommonEnd
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] lineOne = Console.ReadLine().Split();
            string[] lineTwo = Console.ReadLine().Split();

            int shortestLine = Math.Min(lineOne.Length, lineTwo.Length);
            int longestLine = Math.Max(lineOne.Length, lineTwo.Length);

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < shortestLine; i++)
            {
                if (lineOne[i].Equals(lineTwo[i]))
                {
                    countRight++;
                }

                if (lineOne[lineOne.Length - 1 - i].Equals(lineTwo[lineTwo.Length - 1 - i]))
                {
                    countLeft++;
                }
            }

            if (countLeft > countRight)
            {
                Console.WriteLine(countLeft);
            }
            else
            {
                Console.WriteLine(countRight);
            }
        }
    }
}