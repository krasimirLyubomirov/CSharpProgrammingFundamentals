namespace RandomizeWords
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = random.Next(0, words.Length);
                var current = words[i];
                words[i] = words[index];
                words[index] = current;
            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
