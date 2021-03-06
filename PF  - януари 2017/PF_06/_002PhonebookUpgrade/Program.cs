﻿namespace _002PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    break;
                }
                else
                {
                    if (input[0] == "A")
                    {
                        string name = input[1];
                        string phoneNumber = input[2];

                        if (!phonebook.ContainsKey(name))
                        {
                            phonebook.Add(name, phoneNumber);
                        }
                        else
                        {
                            phonebook[name] = phoneNumber;
                        }
                    }
                    else if (input[0] == "S")
                    {
                        string name = input[1];

                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", name);
                        }
                    }
                    else if (input[0] == "ListAll")
                    {
                        var result = phonebook.OrderBy(a => a.Key);

                        foreach (var item in result)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                        }
                    }
                }
            }
        }
    }
}