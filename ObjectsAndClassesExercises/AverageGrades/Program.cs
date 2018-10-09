namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> excellentStudents = new List<Student>();


            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();

                Student next = new Student();
                next.Name = studentData[0];

                for (int j = 1; j < studentData.Length; j++)
                {
                    next.Grades.Add(double.Parse(studentData[j]));
                }

                next.Average = next.Grades.Average();

                if (next.Average >= 5.00)
                {
                    excellentStudents.Add(next);
                }
            }

            excellentStudents = excellentStudents.OrderBy(x => x.Name).ThenByDescending(x => x.Average).ToList();

            foreach (var student in excellentStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
