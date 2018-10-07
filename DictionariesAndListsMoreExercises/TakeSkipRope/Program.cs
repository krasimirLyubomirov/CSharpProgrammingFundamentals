namespace TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<int> numberList = new List<int>();
            List<char> charList = new List<char>();

            foreach (var symbol in encryptedMessage)
            {
                if (char.IsDigit(symbol))
                {
                    int num = int.Parse(symbol.ToString());
                    numberList.Add(num);
                }
                else
                {
                    charList.Add(symbol);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                }
                else
                {
                    skipList.Add(numberList[i]);
                }
            }

            string result = string.Empty;
            int total = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCount = takeList[i];

                result += new string(charList.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }

            Console.WriteLine(result);
        }
    }
}
