namespace _001HornetWings
{
    using System;

    class Program
    {
        static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int restAfter = int.Parse(Console.ReadLine());

            double distanceResult = 0;
            double timeResult = 0;

            distanceResult += (wingFlaps / 1000) * distance;

            timeResult += wingFlaps / 100;
            timeResult += (wingFlaps / restAfter) * 5;

            Console.WriteLine("{0:F2} m.", distanceResult);
            Console.WriteLine("{0} s.", timeResult);
        }
    }
}