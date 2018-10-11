namespace CharacterMultiplier
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string word1 = words[0];
            string word2 = words[1];

            int maxLength = Math.Max(word1.Length, word2.Length);
            int minLength = Math.Min(word1.Length, word2.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += word1[i] * word2[i];

            }

            if (word1.Length != word2.Length)
            {
                string longerWords = word1.Length > word2.Length ? longerWords = word1 : longerWords = word2;

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerWords[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
