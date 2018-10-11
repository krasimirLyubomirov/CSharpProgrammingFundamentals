namespace MelrahShake
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(key);
                int lastIndex = text.LastIndexOf(key);

                if (firstIndex == -1 || firstIndex == lastIndex || key == "")
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                text = text.Remove(lastIndex, key.Length);
                text = text.Remove(firstIndex, key.Length);
                key = key.Remove(key.Length / 2, 1);

                Console.WriteLine("Shaked it.");
            }

            Console.WriteLine(text);
        }
    }
}
