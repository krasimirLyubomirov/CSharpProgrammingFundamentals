namespace TheaThePhotographer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong numPictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong uploadedTime = ulong.Parse(Console.ReadLine());

            ulong minutes = 0;
            ulong hours = 0;
            ulong days = 0;

            ulong filterPictures = numPictures * filterTime;
            ulong filterSeconds = (ulong)Math.Ceiling((numPictures * (filterFactor / 100.0)));
            ulong uploadedSeconds = filterSeconds * uploadedTime;
            ulong totalSeconds = filterPictures + uploadedSeconds;

            if (totalSeconds >= 86400)
            {
                days = totalSeconds / 86400;
                totalSeconds -= days * 86400;
            }
            if (totalSeconds >= 3600)
            {
                hours = totalSeconds / 3600;
                totalSeconds -= hours * 3600;
            }
            if (totalSeconds >= 60)
            {
                minutes = totalSeconds / 60;
                totalSeconds -= minutes * 60;
            }

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{totalSeconds:d2}");
        }
    }
}