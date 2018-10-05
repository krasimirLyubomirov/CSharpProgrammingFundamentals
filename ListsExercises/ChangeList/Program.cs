namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split();

                string command = tokens[0];
                if (command == "Delete")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.RemoveAll(x => x == number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    numbers.Insert(position, number);
                }

                if (command == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                }
                else if (command == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
