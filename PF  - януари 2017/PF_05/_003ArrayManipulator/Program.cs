namespace _003ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "print")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    var index = int.Parse(command[1]);
                    var element = int.Parse(command[2]);
                    AddCommand(index, element, input);
                }
                else if (command[0] == "remove")
                {
                    var index = int.Parse(command[1]);
                    RemoveCommand(index, input);
                }
                else if (command[0] == "contains")
                {
                    var element = int.Parse(command[1]);
                    ContainsCommand(element, input);
                }
                else if (command[0] == "sumPairs")
                {
                    input = SumPairs(input);
                }
                else if (command[0] == "shift")
                {
                    var positions = int.Parse(command[1]);
                    ShiftCommand(positions, input);
                }
                else if (command[0] == "addMany")
                {
                    var index = int.Parse(command[1]);
                    List<int> nElements = new List<int>();
                    for (int i = 2; i < command.Length; i++)
                    {
                        nElements.Add(int.Parse(command[i]));
                    }

                    AddManyCommand(index, nElements, input);
                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static List<int> SumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }

            return numbers;
        }

        private static void ShiftCommand(int positions, List<int> numbers)
        {
            for (int k = 0; k < positions; k++)
            {
                Rotate(numbers);
            }
        }

        private static void RemoveCommand(int index, List<int> numbers)
        {
            numbers.RemoveAt(index);
        }

        private static void ContainsCommand(int element, List<int> numbers)
        {
            if (numbers.Contains(element))
            {
                Console.WriteLine(numbers.FindIndex(a => a == element));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static void AddManyCommand(int index, List<int> nElements, List<int> numbers)
        {
            numbers.InsertRange(index, nElements);
        }

        private static void AddCommand(int index, int element, List<int> numbers)
        {
            numbers.Insert(index, element);
        }

        private static void Rotate(List<int> array)
        {
            int num = array[0];

            for (int i = 0; i < array.Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Count - 1] = num;
        }
    }
}