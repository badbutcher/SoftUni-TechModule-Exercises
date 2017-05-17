namespace _003FoldAndSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSplit = input.Length / 4;
            int rightSplit = input.Length / 4;
            int center = input.Length - (leftSplit + rightSplit);
            int sumSplit = leftSplit + rightSplit;

            int[] leftArray = new int[leftSplit];
            int[] rightArray = new int[rightSplit];
            int[] centerArray = new int[center];
            int[] sumArray = new int[sumSplit];
            int[] resultArray = new int[center];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = input[i];
            }

            int rightPos = 0;
            for (int i = leftSplit + center; i < input.Length; i++)
            {
                rightArray[rightPos] = input[i];
                rightPos++;
            }

            rightPos = 0;

            for (int i = centerArray.Length - leftSplit; i < centerArray.Length + rightSplit; i++)
            {
                centerArray[i - leftSplit] = input[i];
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            for (int i = 0; i < sumArray.Length / 2; i++)
            {
                sumArray[i] = leftArray[i];
            }

            for (int i = sumArray.Length / 2; i < sumArray.Length; i++)
            {
                sumArray[i] = rightArray[rightPos];
                rightPos++;
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = sumArray[i] + centerArray[i];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}