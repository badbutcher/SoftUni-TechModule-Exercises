namespace _004WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";

            foreach (var item in input)
            {
                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftHalf = item.Substring(0, 10);
                    string rightHalf = item.Substring(10, 10);

                    Regex regex = new Regex(pattern);
                    Match matchLeft = regex.Match(leftHalf);
                    Match matchRight = regex.Match(rightHalf);
                    int result = Math.Min(matchLeft.Value.Count(), matchRight.Value.Count());

                    if (matchLeft.Value.Length == result || matchRight.Value.Length == result)
                    {
                        if (matchLeft.Value.Length + matchRight.Value.Length == 20)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", item, matchLeft.Value.Count(), matchLeft.Value[0]);
                        }
                        else if (matchLeft.Length >= 6 && matchRight.Length >= 6)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", item, result, matchLeft.Value[0]);
                        }
                        else
                        {
                            Console.WriteLine("ticket \"{0}\" - no match", item);
                        }
                    }
                }
            }
        }
    }
}