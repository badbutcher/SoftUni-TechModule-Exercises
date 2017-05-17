using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _004QueryMess
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([^&=?]*)=([^&=]*)";
            string whitespce = @"((%20|\+)+)";

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }
                else
                {
                    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
                    Regex regex = new Regex(pattern);
                   
                    for (int i = 0; i < input.Length; i++)
                    {
                        Match matches = regex.Match(input[i]);

                        if (matches.Success)
                        {
                            string key = matches.Groups[1].Value;
                            key = Regex.Replace(key, whitespce, word => " ").Trim();
                            string value = matches.Groups[2].Value;
                            value = Regex.Replace(value, whitespce, word => " ").Trim();

                            if (!result.ContainsKey(key))
                            {
                                List<string> values = new List<string>();
                                values.Add(value);
                                result.Add(key, values);
                            }
                            else
                            {
                                result[key].Add(value);
                            }
                        }
                    }

                    foreach (var item in result)
                    {
                        Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                    }

                    Console.WriteLine();
                }              
            }
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _004QueryMess
//{
//    class Program
//    {
//        static void Main()
//        {
//            string pattern = @"([^&=?]*)=([^&=]*)";
//            string whitespce = @"((%20|\+)+)";

//            while (true)
//            {
//                string input = Console.ReadLine();

//                if (input == "END")
//                {
//                    break;
//                }
//                else
//                {
//                    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
//                    Regex regex = new Regex(pattern);
//                    MatchCollection matches = regex.Matches(input);

//                    for (int i = 0; i < matches.Count; i++)
//                    {
//                        string key = matches[i].Groups[1].Value;
//                        key = Regex.Replace(key, whitespce, word => " ").Trim();
//                        string value = matches[i].Groups[2].Value;
//                        value = Regex.Replace(value, whitespce, word => " ").Trim();

//                        if (!result.ContainsKey(key))
//                        {
//                            List<string> values = new List<string>();
//                            values.Add(value);
//                            result.Add(key, values);
//                        }
//                        else
//                        {
//                            result[key].Add(value);
//                        }
//                    }

//                    foreach (var item in result)
//                    {
//                        Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
//                    }

//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}