namespace _002ConvertFromBaseNToBase10
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseN = input[0];
            string baseTenNum = input[1].ToString();
            baseTenNum = Reverse(baseTenNum);
            BigInteger result = 0;

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                result += (BigInteger)char.GetNumericValue(baseTenNum[i]) * BigInteger.Pow(baseN, i);
            }

            Console.WriteLine(result);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}