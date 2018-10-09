namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Student> studentsList = new List<Student>();

            while (input != "end of dates")
            {
                string[] arr = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = arr[0];

                List<DateTime> dates = new List<DateTime>();

                for (int i = 1; i < arr.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(arr[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (studentsList.Any(x => x.Name.Equals(name)))
                {
                    Student exist = studentsList.First(x => x.Name.Equals(name));
                    exist.Date.AddRange(dates);
                }
                else
                {
                    Student student = new Student
                    {
                        Name = name,
                        Date = dates,
                        Comments = new List<string>()
                    };

                    studentsList.Add(student);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                string[] arr = input.Split('-').ToArray();
                string name = arr[0];
                string comment = arr[1];

                if (studentsList.Any(x => x.Name == name))
                {
                    Student exist = studentsList.First(x => x.Name.Equals(name));
                    exist.Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var student in studentsList.OrderBy(s => s.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                if (student.Date != null)
                {
                    foreach (var date in student.Date.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
    }
}


