namespace IndexOfLetters
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];

            int index = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[index++] = i;
            }

            foreach (char letter in word)
            {
                int foundIndex = IndexOf(alphabet, letter);

                Console.WriteLine($"{letter} -> {foundIndex}");
            }
        }

        static int IndexOf(char[] alphabet, char letter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
