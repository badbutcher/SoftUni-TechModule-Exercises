namespace _004AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> result = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                double[] grades = new double[input.Length];
                for (int j = 1; j < input.Length; j++)
                {
                    grades[j] = double.Parse(input[j]);
                }

                double avrage = grades.Skip(1).Average();
                Student student = new Student() { Name = name, Grades = grades, Average = avrage };
                result.Add(student);
            }

            var sort = result.OrderBy(x => x.Name).ThenByDescending(g => g.Average);
            foreach (var item in sort)
            {
                if (item.Average >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:f2}", item.Name, item.Average);
                }
            }
        }

        public class Student
        {
            public string Name { get; set; }

            public double[] Grades { get; set; }

            public double Average { get; set; }
        }
    }
}