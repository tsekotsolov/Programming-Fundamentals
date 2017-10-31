using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_HornetComm
{
    class P02_HornetComm
    {
        static void Main()
        {
            var input = Console.ReadLine();

            List<string> messageRecipientList = new List<string>();
            List<string> messageMessageList = new List<string>();

            List<string> broadcastFrequencyList = new List<string>();
            List<string> broadcastMessageList = new List<string>();


            while (input != "Hornet is Green")
            {
                var firstQuery = input.Split(new string[] { " <-> " }, StringSplitOptions.None).First();

                var secondQuery = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).First();



                bool containsOnlyDigits = firstQuery.All(c => Char.IsDigit(c));

                bool containsDigitsAndLetters = secondQuery.All(c => Char.IsLetterOrDigit(c));

                bool isMessage = containsOnlyDigits && containsDigitsAndLetters;

                bool isBroadcast = !firstQuery.Any(c => Char.IsDigit(c)) && secondQuery.All(c => Char.IsLetterOrDigit(c));
                
                if (isMessage)
                {

                    char[] arr = firstQuery.ToCharArray();
                    Array.Reverse(arr);
                    var reversed = new string(arr);

                    messageRecipientList.Add(reversed);
                    messageMessageList.Add(secondQuery);
                }

                else if (isBroadcast)
                {
                    broadcastFrequencyList.Add(secondQuery.ToLower());
                    broadcastMessageList.Add(firstQuery);
                }

                

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            for (int i = 0; i < broadcastFrequencyList.Count; i++)
            {
                Console.WriteLine($"{broadcastFrequencyList[i]} -> {broadcastMessageList[i]}");
            }

            Console.WriteLine("Messages:");

            for (int i = 0; i < messageRecipientList .Count; i++)
            {
                Console.WriteLine($"{messageRecipientList[i]} -> {messageMessageList[i]}");
            }

        }
    }
}
