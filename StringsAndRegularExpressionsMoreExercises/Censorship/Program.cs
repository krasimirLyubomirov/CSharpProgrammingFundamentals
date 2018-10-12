namespace Censorship
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            string replace = new string('*', word.Length);

            if (sentence.Contains(word))
            {
                sentence = sentence.Replace(word, replace);
            }

            Console.WriteLine(sentence);
        }
    }
}
