using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _002ExtractSentencesByKeyword
{
    class Program
    {
        static void Main()
        {
            string keyWord = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] {'.','!','?' });
            string pattern = @"\b([word]+)\b";
            string replace = pattern.Replace("word", keyWord);
            Regex regex = new Regex(replace);

            for (int i = 0; i < text.Length; i++)
            {
                MatchCollection match = regex.Matches(text[i]);
                foreach (Match m in match)
                {
                    if (m.Success == true)
                    {
                        Console.WriteLine(text[i].Trim());
                    }
                }
            }
        }
    }
}