using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace P08_MentorGroup
{
    class P08_MentorGroup
    {
        class Student
        {
            public List<string> Comments { get; set; } = new List<string>();
            public List<DateTime> Dates { get; set; } = new List<DateTime>();
            public string Name { get; set; }
        }

        static void Main()
        {
            var inputLineOfDates = Console.ReadLine();

            SortedDictionary<string, Student> studentsDict = new SortedDictionary<string, Student>();

            while (inputLineOfDates != "end of dates")
            {

                var input = inputLineOfDates.Split(' ', ',');

                var name = input.First();

                var dates = input
                    .Skip(1)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .OrderBy(x => x)
                    .ToList();

                Student currentstudent = new Student()
                {
                    Name = name,
                    Dates = dates
                };
                if (!studentsDict.ContainsKey(name))

                {
                    studentsDict.Add(name, currentstudent);
                }

                else
                {
                    studentsDict[name].Dates.AddRange(currentstudent.Dates);
                }

                inputLineOfDates = Console.ReadLine();
            }

            var inputLineOfComments = Console.ReadLine();

            while (inputLineOfComments != "end of comments")
            {
                var input = inputLineOfComments.Split('-');

                var name = input.First();

                var comments = input
                    .Skip(1)
                    .OrderBy(x => x)
                    .ToList();

                if (studentsDict.ContainsKey(name))

                {
                    Student currentstudent = new Student()
                    {
                        Name = name,
                        Comments = comments
                    };
                    studentsDict[name].Comments.AddRange(currentstudent.Comments);
                }

                inputLineOfComments = Console.ReadLine();
            }

            foreach (var student in studentsDict)
            {
                Console.WriteLine(student.Key);

                Console.WriteLine("Comments:");
                foreach (var item in student.Value.Comments)
                {

                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var item in student.Value.Dates)
                {

                    Console.WriteLine($"-- {item:dd/MM/yyyy}");
                }

            }

        }

    }
}
