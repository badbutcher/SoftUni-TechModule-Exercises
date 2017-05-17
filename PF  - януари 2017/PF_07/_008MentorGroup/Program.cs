namespace _008MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of dates")
                {
                    break;
                }
                else
                {
                    List<string> usersDates = input.Split(',', ' ').ToList();
                    string name = usersDates[0];
                    usersDates.RemoveAt(0);
                    List<DateTime> dates = usersDates.Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    bool isRegistered = false;

                    foreach (var stud in students)
                    {
                        if (stud.Name == name)
                        {
                            isRegistered = true;
                            stud.Dates.AddRange(dates);
                            break;
                        }
                    }

                    if (isRegistered == false)
                    {
                        Student student = new Student() { Name = name, Dates = dates, Comments = new List<string>() };
                        students.Add(student);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = data[0];

                    foreach (var item in students)
                    {
                        if (item.Name == name)
                        {
                            string comment = data[1];

                            item.Comments.Add(comment);
                        }
                    }
                }
            }

            foreach (var item in students.OrderBy(a => a.Name))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");

                if (item.Comments.Count != 0)
                {
                    foreach (var comment in item.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }


                Console.WriteLine("Dates attended:");
                if (item.Dates.Count != 0)
                {
                    foreach (var date in item.Dates.OrderBy(a => a.Date))
                    {
                        Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                    }
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }
    }
}