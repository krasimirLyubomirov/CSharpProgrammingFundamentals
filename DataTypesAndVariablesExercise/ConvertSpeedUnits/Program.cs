using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smsTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            hours = hours + minutes / 60.0f + seconds / 3600.0f;
            float kmPerHours = (distance / 1000.0f) / hours;
            float mPerSeconds = distance / (hours * 3600);
            float milesPerHours = (distance / 1609.0f) / hours;

            Console.WriteLine($"{mPerSeconds:f7}");
            Console.WriteLine($"{kmPerHours:f7}");
            Console.WriteLine($"{milesPerHours:f7}");
        }
    }
}
