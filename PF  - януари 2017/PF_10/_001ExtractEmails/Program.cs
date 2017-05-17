using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _001ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<![\.\-])([a-zA-Z0-9\.\-]+)@([a-zA-Z\-]+\.)([a-zA-Z\-\.]{2,})\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}