namespace ManipulateArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split().ToList();
            int number = int.Parse(Console.ReadLine());

            List<string> commands = new List<string>();
            List<string> stringArray = new List<string>();

            for (int i = 0; i < number; i++)
            {
                commands = Console.ReadLine().Split().ToList();

                int index = 0;

                if (commands[0] == "Distinct")
                {
                    array = array.Distinct().ToList();
                }
                else if (commands[0] == "Reverse")
                {
                    array.Reverse();
                }
                else if (commands[0] == "Replace")
                {
                    if (int.TryParse(commands[1], out index))
                    {
                        array.RemoveAt(index);
                        array.Insert(index, commands[2]);
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
