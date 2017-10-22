using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P06_Book_Library_Modification
{
    class Program
    {

        class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime IssueDate { get; set; }
            public string Isbn { get; set; }
            public decimal Price { get; set; }

        }
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, DateTime>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputLine =
                    Console.ReadLine()
                    .Split();

                Book book = new Book();
                book = CreateSingleBook(inputLine);

                if (!result.ContainsKey(book.Author))
                {
                    result[book.Name] = book.IssueDate;

                }
            }

            var checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            result = result.OrderBy(pair => pair.Value)
              .ThenBy(pair => pair.Key)
              .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var KeyPairValue in result)
            {
                if (KeyPairValue.Value>checkDate)
                {
                    Console.WriteLine($"{KeyPairValue.Key} -> {KeyPairValue.Value.ToString("dd.MM.yyyy")}");
                }

            }

        }

        private static Book CreateSingleBook(string[] inputLine)
        {
            Book book = new Book();

            book.Name = inputLine[0];
            book.Author = inputLine[1];
            book.Publisher = inputLine[2];
            book.IssueDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.Isbn = inputLine[4];
            book.Price = decimal.Parse(inputLine[5]);

            return book;
        }
    }
}
