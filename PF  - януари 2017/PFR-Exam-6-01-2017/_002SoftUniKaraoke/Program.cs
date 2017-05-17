namespace _002SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> participants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToList();

            Dictionary<string, HashSet<string>> awards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string singer = data[0].Trim();
                    string song = data[1].Trim();
                    string award = data[2].Trim();

                    if (participants.Contains(singer) && songs.Contains(song))
                    {
                        if (!awards.ContainsKey(singer))
                        {
                            awards.Add(singer, new HashSet<string>());
                            awards[singer].Add(award);
                        }
                        else
                        {
                            awards[singer].Add(award);
                        }
                    }
                }
            }

            var result = awards.OrderByDescending(a => a.Value.Count).ThenBy(b => b.Key);

            if (result.Count() == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine("{0}: {1} awards", item.Key, item.Value.Count);

                    foreach (var a in item.Value.OrderBy(a => a))
                    {
                        Console.WriteLine("--{0}", a);
                    }
                }
            }
        }
    }
}