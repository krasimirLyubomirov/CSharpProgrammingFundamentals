namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "print")
                {
                    Console.WriteLine("[{0}]", String.Join(", ", numbers));
                    break;
                }

                string[] tokens = line.Split();
                string commands = tokens[0];

                int index;
                int element;

                switch (commands)
                {
                    case "add":
                        index = int.Parse(tokens[1]);
                        element = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        AddMany(numbers, tokens);
                        break;
                    case "contains":
                        element = int.Parse(tokens[1]);
                        index = numbers.IndexOf(element);
                        Console.WriteLine(index);
                        break;
                    case "remove":
                        index = int.Parse(tokens[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        int rotations = int.Parse(tokens[1]);
                        Shift(numbers, rotations);
                        break;
                    case "sumPairs":
                        SumPairs(numbers);
                        break;
                }
            }
        }

        static void AddMany(List<int> numbers, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            List<int> numbersToAdd = new List<int>();
            for (int i = 2; i < tokens.Length; i++)
            {
                numbersToAdd.Add(int.Parse(tokens[i]));
            }
            numbers.InsertRange(index, numbersToAdd);
        }

        static void SumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        static void Shift(List<int> numbers, int rotations)
        {
            for (int i = 0; i < rotations % numbers.Count; i++)
            {
                int first = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(first);
            }
        }
    }
}
