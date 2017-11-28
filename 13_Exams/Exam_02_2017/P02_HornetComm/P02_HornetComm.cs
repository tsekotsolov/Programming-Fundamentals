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

                    StringBuilder s = new StringBuilder();

                    for (int i = 0; i < secondQuery.Length; i++)
                    {
                        

                        if (Char.IsLower(secondQuery[i]))
                        {
                            var upperletter = secondQuery[i].ToString().ToUpper()  ;
                            s.Append(upperletter);
                        }
                        else if (Char.IsUpper(secondQuery[i]))
                        {
                            var lowerletter = secondQuery[i].ToString().ToLower();
                            s.Append(lowerletter);
                        }
                        else
                        {
                            s.Append(secondQuery[i]);
                        }

                    }

                    broadcastFrequencyList.Add(s.ToString());  
                    broadcastMessageList.Add(firstQuery);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcastFrequencyList.Count != 0)
            {
                for (int i = 0; i < broadcastFrequencyList.Count; i++)
                {
                    Console.WriteLine($"{broadcastFrequencyList[i]} -> {broadcastMessageList[i]}");
                }
            }

            else
            {
                Console.WriteLine("None");
            }


            Console.WriteLine("Messages:");

            if (messageRecipientList.Count != 0)
            {
                for (int i = 0; i < messageRecipientList.Count; i++)
                {
                    Console.WriteLine($"{messageRecipientList[i]} -> {messageMessageList[i]}");
                }
            }

            else
            {
                Console.WriteLine("None");
            }

        }
    }
}
