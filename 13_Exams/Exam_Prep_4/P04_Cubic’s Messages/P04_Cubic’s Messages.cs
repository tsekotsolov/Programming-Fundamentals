using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace P04_Cubic_s_Messages
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, string>();


            while (input != "Over!")
            {
                var numberOfCharecters = int.Parse(Console.ReadLine());
                var message = returnsMessage(input, numberOfCharecters);

                if (message != string.Empty && message.Length == numberOfCharecters)
                {
                    var digitPattren = @"[0-9+]";
                    var allDigits = Regex.Matches(input, digitPattren);

                    var listofIndexes = new List<int>();

                    foreach (Match digit in allDigits)
                    {

                        listofIndexes.Add(int.Parse(digit.Value));

                    }

                    var verificationCodeBag = new StringBuilder();

                    foreach (var index in listofIndexes)
                    {
                        if (index >= 0 && index <= message.Length - 1)
                        {
                            verificationCodeBag.Append(message[index]);
                        }
                        else
                        {
                            verificationCodeBag.Append(" ");
                        }
                    }

                    var verificationCode = verificationCodeBag.ToString();


                    result.Add(message, verificationCode);

                }

                input = Console.ReadLine();

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }

        }

        private static string returnsMessage(string input, int numberOfCharecters)
        {
            string pattern = @"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            var message = match.Groups[2].ToString();

            return message;
        }
    }
}