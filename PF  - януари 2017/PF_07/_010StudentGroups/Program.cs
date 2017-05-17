namespace _010StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Town> result = ReadTownsAndStudents();
            List<Group> finish = DistributeStudentsInfoGroups(result);

            Console.WriteLine("Created {0} groups in {1} towns:", finish.Count, result.Count);
            foreach (var group in finish)
            {
                Console.WriteLine("{0} => {1}",
                                group.Town.Name,
                                string.Join(", ", group.Students.Select(x => x.Email).ToList()));
            }
        }

        private static List<Group> DistributeStudentsInfoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(a => a.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(a => a.RegistrationDate).ThenBy(b => b.Name).ThenBy(c => c.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {
                    if (input.Contains("=>"))
                    {
                        string[] data = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                        Town t = new Town();
                        t.Students = new List<Student>();
                        string townName = data[0].Trim();
                        int seatsCount = int.Parse(string.Join("", data[1].ToCharArray().Where(Char.IsDigit)));
                        t.Name = townName;
                        t.SeatsCount = seatsCount;
                        towns.Add(t);
                    }
                    else
                    {
                        string[] data = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        Student s = new Student();
                        string studentName = data[0].Trim();
                        string email = data[1].Trim();
                        DateTime date = Convert.ToDateTime(data[2]);
                        s.Name = studentName;
                        s.Email = email;
                        s.RegistrationDate = date;
                        towns[towns.Count - 1].Students.Add(s);
                    }
                }
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }
}