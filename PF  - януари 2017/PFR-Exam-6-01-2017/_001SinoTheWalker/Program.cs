namespace _001SinoTheWalker
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime leaveTime = DateTime.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timeForStep = int.Parse(Console.ReadLine()) % 86400;

            long time = steps * timeForStep;

            Console.WriteLine("Time Arrival: " + leaveTime.AddSeconds(time).ToString("HH:mm:ss"));
        }
    }
}