namespace _012MasterNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (Symmetric(i) && DivisibleBySeven(i) && OneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool Symmetric(int input)
        {
            string number = input.ToString();
            int min = 0;
            int max = number.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char first = number[min];
                char last = number[max];
                if (char.ToLower(first) != char.ToLower(last))
                {
                    return false;
                }

                min++;
                max--;
            }
        }

        private static bool DivisibleBySeven(int input)
        {
            string number = input.ToString();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());      
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool OneEvenDigit(int input)
        {
            string number = input.ToString();
            int counter = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = int.Parse(number[i].ToString());

                if (currentNumber % 2 == 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}