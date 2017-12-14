using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03_RainCast
{
    class P03_RainCast

    {

        static void Main()
        {
            var input = Console.ReadLine();


            var typePattern = @"(^Type:\s)(Normal|Danger|Warning)$";
            var sourcePattern = @"(^Source:\s)([A-Za-z0-9]+$)";
            var foreCastPattern = @"(^Forecast:\s)([^\.?,!\n]+$)";

            var type = string.Empty;
            var forecast = string.Empty;
            string source = string.Empty;

            var listType = new List<string>();
            var listForecast = new List<string>();
            var sourceList = new List<string>();


            while (input != "Davai Emo")
            {
                if (Regex.IsMatch(input, typePattern) && type == string.Empty)
                {
                    Regex regex = new Regex(typePattern);
                    Match match = regex.Match(input);

                    type = match.Groups[2].ToString();
                }


                else if (Regex.IsMatch(input, sourcePattern))
                {
                    if (type != string.Empty && source == string.Empty)
                    {
                        Regex regex = new Regex(sourcePattern);
                        Match match = regex.Match(input);

                        source = match.Groups[2].ToString();
                    }
                }

                else if (Regex.IsMatch(input, foreCastPattern))
                {
                    if (type != string.Empty && source != string.Empty)
                    {
                        Regex regex = new Regex(foreCastPattern);
                        Match match = regex.Match(input);

                        forecast = match.Groups[2].ToString();
                    }
                }

                if (type != string.Empty && forecast != string.Empty && source != string.Empty)
                {
                    listType.Add(type);
                    listForecast.Add(forecast);
                    sourceList.Add(source);


                    type = string.Empty;
                    forecast = string.Empty;
                    source = string.Empty;

                }

                input = Console.ReadLine();
            }


            for (int i = 0; i < listType.Count; i++)
            {
                Console.WriteLine($"({listType[i]}) {listForecast[i]} ~ {sourceList[i]}");
            }

        }
    }
}
