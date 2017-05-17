namespace _003EnduranceRally
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] participants = Console.ReadLine().Split();
            double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < participants.Length; i++)
            {
                string racerName = participants[i];
                double fuel = racerName[0];

                for (int j = 0; j < track.Length; j++)
                {
                    bool found = false;

                    for (int k = 0; k < checkPoints.Length; k++)
                    {
                        if (j == checkPoints[k])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        fuel += track[j];
                    }
                    else
                    {
                        fuel -= track[j];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", racerName, j);
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", racerName, fuel);
                }
            }
        }
    }
}