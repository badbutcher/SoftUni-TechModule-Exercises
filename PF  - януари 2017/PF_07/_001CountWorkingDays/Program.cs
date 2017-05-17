namespace _001CountWorkingDays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int workDays = 0;
            int[] start = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            int[] end = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime startDate = new DateTime(start[2], start[1], start[0]);
            DateTime endData = new DateTime(end[2], end[1], end[0]);
            DateTime[] officialHolidays = new DateTime[11];

            officialHolidays[0] = new DateTime(start[2], 01, 01);
            officialHolidays[1] = new DateTime(start[2], 03, 03);
            officialHolidays[2] = new DateTime(start[2], 05, 01);
            officialHolidays[3] = new DateTime(start[2], 05, 06);
            officialHolidays[4] = new DateTime(start[2], 05, 24);
            officialHolidays[5] = new DateTime(start[2], 09, 06);
            officialHolidays[6] = new DateTime(start[2], 09, 22);
            officialHolidays[7] = new DateTime(start[2], 11, 01);
            officialHolidays[8] = new DateTime(start[2], 12, 24);
            officialHolidays[9] = new DateTime(start[2], 12, 25);
            officialHolidays[10] = new DateTime(start[2], 12, 26);

            for (DateTime date = startDate; date.Date <= endData; date = date.AddDays(1))
            {
                var saturDay = date.DayOfWeek == DayOfWeek.Saturday;
                var sunDay = date.DayOfWeek == DayOfWeek.Sunday;
                var holiDay = officialHolidays.Any(d => d.Month == date.Month && d.Day == date.Day);
                if (!(saturDay || sunDay || holiDay))
                {
                    workDays++;
                }
            }

            Console.WriteLine(workDays);
        }
    }
}