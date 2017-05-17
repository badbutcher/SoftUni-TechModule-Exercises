namespace _005CompareCharArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] lineOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] lineTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(lineOne.Length, lineTwo.Length); i++)
            {
                if (lineOne[i] > lineTwo[i])
                {
                    Console.WriteLine(string.Join(string.Empty, lineTwo));
                    Console.WriteLine(string.Join(string.Empty, lineOne));
                    break;
                }
                else if (lineOne[i] < lineTwo[i])
                {
                    Console.WriteLine(string.Join(string.Empty, lineOne));
                    Console.WriteLine(string.Join(string.Empty, lineTwo));
                    break;
                }
                else if (lineOne.Length > lineTwo.Length)
                {
                    Console.WriteLine(string.Join(string.Empty, lineTwo));
                    Console.WriteLine(string.Join(string.Empty, lineOne));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, lineOne));
                    Console.WriteLine(string.Join(string.Empty, lineTwo));
                    break;
                }
            }
        }
    }
}