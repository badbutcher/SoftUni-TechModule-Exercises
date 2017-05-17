namespace _007MultiplyBigNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int numberInMind = 0;
            int leftOver = 0;

            if (b >= 0 && b <= 9)
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    int numSum = (int)(int.Parse(a[i].ToString()) * b + numberInMind);
                    numberInMind = (int)(numSum / 10);
                    leftOver = (int)(numSum % 10);
                    result += leftOver;

                    if (i == 0 && numberInMind != 0)
                    {
                        result += numberInMind;
                    }
                }

                var printRes = Reverse(result).TrimStart('0');
                if (printRes == string.Empty)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(Reverse(result).TrimStart('0'));
                }
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}