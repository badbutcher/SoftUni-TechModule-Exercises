using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _005UseYourChainsBuddy
{
    class Program
    {
        static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string pattern = @"<p>(.*?)<\/p>";
            string removePattern = @"([^a-z0-9]+)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> tags = new List<string>();
            for (int i = 0; i < matches.Count; i++)
            {
                string tag = matches[i].Groups[1].Value;
                tag = Regex.Replace(tag, removePattern, word => " ");
                tags.Add(tag);
            }

            string result = string.Empty;
            foreach (var item in tags)
            {
                string text = string.Empty;
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] >= 'a' && item[i] <= 'm')
                    {
                        text += (char)(item[i] + 13);
                    }
                    else if (item[i] >= 'n' && item[i] <= 'z')
                    {
                        text += (char)(item[i] - 13);
                    }
                    else if (Char.IsDigit(item[i]) || Char.IsWhiteSpace(item[i]))
                    {
                        text += item[i];
                    }
                }

                result += text;
            }

            Console.WriteLine(result);
        }
    }
}