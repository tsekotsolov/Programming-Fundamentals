using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_WinningTicket
{
    class P04_WinningTicket
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length == 20)
                {
                    var firstHalf = input[i].Substring(0, 10);
                    var secondHalf = input[i].Substring(10, 10);

                    var luckyPattern = @"\${6,9}|\@{6,9}|\#{6,9}|\^{6,9}";
                    var jackpotPattern = @"\${20}|\@{20}|\#{20}|\^{20}";

                    var firstMatch = Regex.Match(firstHalf, luckyPattern).ToString();
                    var secondMatch = Regex.Match(secondHalf, luckyPattern).ToString();

                    bool isWinningTicket = firstMatch.Length >= 6 && secondMatch.Length >= 6 && firstMatch[0] == secondMatch[0];
                    bool isJackPot = Regex.IsMatch(input[i], jackpotPattern);


                    if (isJackPot)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - 10{input[i].First()} Jackpot!");
                    }

                    else if (isWinningTicket)
                    {
                        if (firstMatch.Length > secondMatch.Length)
                        {
                            Console.WriteLine($@"ticket ""{input[i]}"" - {secondMatch.Length}{secondMatch[0]}");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{input[i]}"" - {firstMatch.Length}{firstMatch[0]}");
                        }


                    }

                    else
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - no match");
                    }
                }

                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }

        }
    }
}
