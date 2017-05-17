namespace _004HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> armada = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            string pattern = @"([0-9]+) = (.*) -> (.*):([0-9]+)";

            long n = long.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = Regex.Split(input, pattern);

                long lastActivity = long.Parse(data[1]);
                string legionName = data[2];
                string soldierType = data[3];
                long soldierCount = long.Parse(data[4]);

                if (!armada.ContainsKey(legionName))
                {
                    armada.Add(legionName, new Dictionary<string, long>());
                    legionActivity.Add(legionName, lastActivity);
                }

                if (lastActivity > legionActivity[legionName])
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (!armada[legionName].ContainsKey(soldierType))
                {
                    armada[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    armada[legionName][soldierType] += soldierCount;
                }
            }

            string[] command = Console.ReadLine().Split('\\');

            if (command.Length > 1)
            {
                long activ = long.Parse(command[0]);
                string type = command[1];
                var result = armada.Where(a => a.Value.ContainsKey(type)).OrderByDescending(c => c.Value[type]);

                foreach (var item in result)
                {
                    if (legionActivity[item.Key] < activ)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, armada[item.Key][type]);
                    }
                }
            }
            else
            {
                foreach (var item in legionActivity.OrderByDescending(a => a.Value))
                {
                    if (armada[item.Key].ContainsKey(command[0]))
                    {
                        Console.WriteLine("{0} : {1}", item.Value, item.Key);
                    }
                }
            }
        }
    }
}