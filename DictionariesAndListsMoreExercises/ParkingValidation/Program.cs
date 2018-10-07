namespace ParkingValidation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> userAndLicense = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0].ToLower();
                string user = input[1];

                if (command == "unregister")
                {
                    Unregister(userAndLicense, user);
                }
                else if (command == "register")
                {
                    string license = input[2];
                    Register(userAndLicense, user, license);
                }
            }

            foreach (var item in userAndLicense)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        public static void Unregister(Dictionary<string, string> userAndLicense, string user)
        {
            if (userAndLicense.ContainsKey(user) == false)
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
            else
            {
                userAndLicense.Remove(user);
                Console.WriteLine($"user {user} unregistered successfully");
            }
        }

        public static void Register(Dictionary<string, string> userAndLicense, string user, string license)
        {
            if ((userAndLicense.ContainsKey(user)) && (userAndLicense[user] != license))
            {
                Console.WriteLine($"ERROR: already registered with plate number {userAndLicense[user]}");
                return;
            }

            if (CheckIfValid(license) == false)
            {
                Console.WriteLine($"ERROR: invalid license plate {license}");
                return;
            }

            foreach (var item in userAndLicense)
            {
                if (item.Key != user && item.Value == license)
                {
                    Console.WriteLine($"ERROR: license plate {license} is busy");
                    return;
                }
            }

            userAndLicense[user] = license;
            Console.WriteLine($"{user} registered {license} successfully");
        }

        public static bool CheckIfValid(string license)
        {
            if (license.Length != 8)
            {
                return false;
            }

            char[] licenseLetters = new char[] { license[0], license[1], license[6], license[7]};

            foreach (var letter in licenseLetters)
            {
                if (letter < 65 || letter > 90)
                {
                    return false;
                }
            }

            for (int i = 2; i <= 5; i++)
            {
                if (license[i] < 48 || license[i] > 57)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
