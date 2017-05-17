namespace _003HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<long> bees = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> beesLeft = new List<long>();

            for (int i = 0; i < bees.Count; i++)
            {
                long beesPower = bees[i];

                long hornetsSum = hornets.Sum();

                if (beesPower >= hornetsSum)
                {
                    if (beesPower - hornetsSum > 0)
                    {
                        beesLeft.Add(beesPower - hornetsSum);

                        if (hornets.Count == 0)
                        {
                            break;
                        }
                    }

                    hornets.RemoveAt(0);
                }
            }

            if (beesLeft.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beesLeft));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}