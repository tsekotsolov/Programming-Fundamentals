using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace P03_RainCast
{
    class P03_RainCast

    {
        class RainCast
        {
            public string Source { get; set; }
            public string Forecast { get; set; }
        }

        static void Main()
        {
            var input = Console.ReadLine();

            var typeDangerPattern = @"^Type:\sDanger";
            var typeWarningPattern = @"^Type:\sWarning";
            var typeNormalPattern = @"^Type:\sNormal";
            var sourcePattern = @"^Source:\s[A-Za-z0-9]+$";
            var foreCastPattern = @"^Forecast:\s[^\.?,!\n]+$";

            var type = string.Empty;
            var forecast = string.Empty;
            string source = string.Empty;

            var listType = new List<string>();
            var listForecast = new List<string>();
            var sourceList = new List<string>();


            while (input != "Davai Emo")
            {

                if (type!=string.Empty&&forecast!=String.Empty&&source!=string.Empty)
                {
                    listType.Add(type);
                    listForecast.Add(forecast);
                    sourceList.Add(source);


                     type = string.Empty;
                     forecast = string.Empty;
                     source = string.Empty;

                }


                if (Regex.IsMatch(typeDangerPattern, input))
                {
                    type = "(Danger)";
                }

                else if (Regex.IsMatch(typeWarningPattern, input))
                {
                    type = "(Warning)";
                }

                else if (Regex.IsMatch(typeNormalPattern, input))
                {
                    type = "(Normal)";
                }

                if (Regex.IsMatch(sourcePattern,input))
                {
                    if (type!=string.Empty)
                    {
                        var fullsource = Regex.Match(source, input).ToString();

                        source = fullsource.Substring(7);
                    }
                }

                if (Regex.IsMatch(foreCastPattern,input))
                {
                    if (type != string.Empty&&source!=string.Empty)
                    {
                        var fullforecast = Regex.Match(foreCastPattern,input).ToString();

                        forecast = fullforecast.Substring(9);
                    }
                }

                if (true)
                {

                }

                
         
                input = Console.ReadLine();
            }



            Console.WriteLine();

        }
    }
}
