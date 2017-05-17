using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _003ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"\b^[a-zA-Z]([\w\d_]{2,24})\b";
            Regex regex = new Regex(pattern);
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection matches = Regex.Matches(input[i], pattern);

                foreach (var item in matches)
                {
                    validUsernames.Add(item.ToString());
                }
            }

            int longest = 0;
            string firstUsername = string.Empty;
            string secondUsername = string.Empty;

            for (int i = 1; i < validUsernames.Count; i++)
            {
                string wordOne = validUsernames[i - 1];
                string wordTwo = validUsernames[i];

                if (wordOne.Length + wordTwo.Length > longest)
                {
                    longest = wordOne.Length + wordTwo.Length;
                    firstUsername = wordOne;
                    secondUsername = wordTwo;
                }
            }

            Console.WriteLine(firstUsername);
            Console.WriteLine(secondUsername);
        }
    }
}