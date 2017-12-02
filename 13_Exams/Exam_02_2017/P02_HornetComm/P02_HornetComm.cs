using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace P02_HornetComm
{

    class HornetComm
    {
        static void Main()
        {
            var input = Console.ReadLine();



            var recepientCode = new List<string>();
            var recepientMessage = new List<string>();

            var broadcastFrequency = new List<string>();
            var broadcastMessage = new List<string>();

            while (input != "Hornet is Green")
            {
                string firstQuery, secondQuery;


                var privatemessagePattern = @"(^[0-9\n]+)\s<->\s([0-9A-Za-z]+)$";
                var broadcastPattern = @"(^[^0-9\n]+)\s<->\s([0-9A-Za-z]+)$";

                if (Regex.IsMatch(input, privatemessagePattern))
                {
                    SplitQueries(input, out firstQuery, out secondQuery);
                    var code = Reverse(firstQuery);

                    recepientCode.Add(code);
                    recepientMessage.Add(secondQuery);
                }
                else if (Regex.IsMatch(input, broadcastPattern))
                {
                    SplitQueries(input, out firstQuery, out secondQuery);
                    StringBuilder bag = TransformLetters(secondQuery);

                    broadcastFrequency.Add(bag.ToString());
                    broadcastMessage.Add(firstQuery);
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Broadcasts:");
            PrintResult(broadcastFrequency, broadcastMessage);


            Console.WriteLine("Messages:");
            PrintResult(recepientCode, recepientMessage);
        }

        private static void SplitQueries(string input, out string firstQuery, out string secondQuery)
        {
            firstQuery = input.Split(new string[] { " <-> " }, StringSplitOptions.None).First();
            secondQuery = input.Split(new string[] { " <-> " }, StringSplitOptions.None).Skip(1).First();
        }

        private static StringBuilder TransformLetters(string secondQuery)
        {
            var bag = new StringBuilder();

            foreach (var symbol in secondQuery)
            {
                if (Char.IsUpper(symbol))
                {
                    bag.Append(symbol.ToString().ToLower());
                }
                else if (Char.IsLower(symbol))
                {
                    bag.Append(symbol.ToString().ToUpper());
                }
                else
                {
                    bag.Append(symbol);
                }
            }

            return bag;
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        private static void PrintResult(List<string> firstListToPrint, List<string> secondListToPrint)
        {


            if (firstListToPrint.Count != 0)
            {

                for (int i = 0; i < firstListToPrint.Count; i++)
                {
                    Console.WriteLine($"{firstListToPrint[i]} -> {secondListToPrint[i]}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
