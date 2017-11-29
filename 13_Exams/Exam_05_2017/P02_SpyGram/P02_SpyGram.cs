using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02_SpyGram
{
    class P02_SpyGram
    {
        static void Main()
        {
            var privateKeyInitial = Console.ReadLine();

            var message = Console.ReadLine();

            var messageBox = new SortedDictionary<string, List<string>>();

            while (message != "END")
            {
                bool isMessage = ChecksValidity(message);

                if (isMessage)
                {
                    MessageProcess(privateKeyInitial, message, messageBox);

                }
                message = Console.ReadLine();
            }

            PrintResult(messageBox);

        }

        private static bool ChecksValidity(string message)
        {
            bool isMessage = false;

            var pattern = @"(TO:\s[A-Z]+;)(\sMESSAGE:.+)";

            if (Regex.IsMatch(message, pattern))
            {
                isMessage = true;
            }

            return isMessage;
        }
        private static string KeyEqualizer(string privateKey, string message)
        {
            if (message.Length > privateKey.Length)
            {
                var delta = message.Length - privateKey.Length;

                for (int i = 0; i < delta; i++)
                {
                    privateKey = privateKey + privateKey[i];
                }

            }

            return privateKey;
        }
        private static void MessageProcess(string privateKeyInitial, string message, SortedDictionary<string, List<string>> messageBox)
        {
            var privateKey = KeyEqualizer(privateKeyInitial, message);

            var patternName = @"(?<=\s)[A-Z]+(?=;)";
            var name = Regex.Match(message, patternName).ToString();
            var encodedMessage = string.Empty;
            var messageList = new List<string>();

            var count = 0;
            foreach (var symbol in message)
            {
                var currentKey = privateKey[count++].ToString();
                var currentCharASCIINumber = symbol + int.Parse(currentKey);
                var currentChar = (char)currentCharASCIINumber;
                encodedMessage = encodedMessage + currentChar;
            }

            messageList.Add(encodedMessage);

            if (!messageBox.ContainsKey(name))
            {
                messageBox.Add(name, messageList);
            }

            else
            {
                messageBox[name].AddRange(messageList);
            }
        }
        private static void PrintResult(SortedDictionary<string, List<string>> messageBox)
        {
            foreach (var name in messageBox)
            {
                foreach (var mes in name.Value)
                {
                    Console.WriteLine(mes);
                }

            }
        }
    }
}
