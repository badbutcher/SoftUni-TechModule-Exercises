namespace _011ConvertSpeedUnits
{
    using System;

    class Program
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = hours * 3600 + minutes * 60 + seconds;

            Console.WriteLine("{0:0.#######}", (float)distance / time);
            Console.WriteLine("{0:0.#######}", ((float)distance / 1000) / ((float)time / 3600));
            Console.WriteLine("{0:0.#######}", ((float)distance / 1609) / ((float)time / 3600));
        }
    }
}