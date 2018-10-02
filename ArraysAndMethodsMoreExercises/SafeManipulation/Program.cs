namespace SafeManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split().ToList();
            List<string> commands = new List<string>();

            while(true)
            {
                commands = Console.ReadLine().Split().ToList();

                int index = 0;
                if (commands[0] == "END")
                {
                    break;
                }
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
                    try
                    {
                        if (int.TryParse(commands[1], out index))
                        {
                            array.RemoveAt(index);
                            array.Insert(index, commands[2]);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }
    }
}
