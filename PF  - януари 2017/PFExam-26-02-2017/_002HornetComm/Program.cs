﻿namespace _002HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            string broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";

            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string inputLine = Console.ReadLine();

            while (inputLine != "Hornet is Green")
            {
                if (messageRegex.IsMatch(inputLine))
                {
                    Match match = messageRegex.Match(inputLine);

                    string recipientCode = string.Join(string.Empty, match.Groups[1].Value.Reverse());

                    string message = match.Groups[2].Value;

                    messages.Add(recipientCode + " -> " + message);
                }

                if (broadcastRegex.IsMatch(inputLine))
                {
                    Match match = broadcastRegex.Match(inputLine);

                    string message = match.Groups[1].Value;

                    string frequency = DecryptFrequency(match.Groups[2].Value);

                    broadcasts.Add(frequency + " -> " + message);
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static string DecryptFrequency(string value)
        {
            string res = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]))
                {
                    res += value[i].ToString().ToUpper();
                }
                else if (char.IsUpper(value[i]))
                {
                    res += value[i].ToString().ToLower();
                }
                else
                {
                    res += value[i];
                }
            }

            return res;
        }
    }
}