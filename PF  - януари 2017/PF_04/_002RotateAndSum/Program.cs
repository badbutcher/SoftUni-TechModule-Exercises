namespace _002RotateAndSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int k = 0; k < n; k++)
            {
                Rotate(array);

                for (int i = 0; i < array.Length; i++)
                {
                    sum[i] += array[i];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void Rotate(int[] array)
        {
            int num = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = num;
        }
    }
}