namespace _019TheaThePhotographer
{
    using System;

    class Program
    {
        static void Main()
        {
            double pictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double usefulPercentage = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double usefulPictures = Math.Ceiling((pictures * usefulPercentage) / 100);
            double totalFilterTime = pictures * filterTime;
            double totalUploadTime = usefulPictures * uploadTime;
            double totalTime = totalFilterTime + totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", time.Days, time.Hours, time.Minutes, time.Seconds);
        }
    }
}