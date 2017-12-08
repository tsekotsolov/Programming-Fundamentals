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

        }

        static void Main()
        {
            var inputLineOfDates = Console.ReadLine();

            Dictionary<string, Student> studentsDict = new Dictionary<string, Student>();

            while (inputLineOfDates != "end of dates")
            {

                var input = inputLineOfDates.Split(' ', ',');


                var name = input.First();

                var dates = input
                    .Skip(1)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();

                Student currentstudent = new Student()
                {

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
                    .ToList();

                if (studentsDict.ContainsKey(name))

                {
                    Student currentstudent = new Student()
                    {

                        Comments = comments
                    };
                    studentsDict[name].Comments.AddRange(currentstudent.Comments);
                }

                inputLineOfComments = Console.ReadLine();
            }

            foreach (var student in studentsDict.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);

                Console.WriteLine("Comments:");
                foreach (var item in student.Value.Comments)
                {

                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var item in student.Value.Dates.OrderBy(x => x))
                {

                    Console.WriteLine($"-- {item:dd/MM/yyyy}");
                }

            }

        }

    }
}
