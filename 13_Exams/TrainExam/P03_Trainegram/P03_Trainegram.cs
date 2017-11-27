using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace P03_Trainegram
{
    class P03_Trainegram
    {
        static void Main()
        {
            
            var pattern = @"^(<\[([^A-Za-z0-9]+?)?\]\.)((\.\[([A-Za-z0-9+]+)?\]\.)+)?$";

            var input =Console.ReadLine();

            var bag = new StringBuilder();

            while (input!= "Traincode!")
            {
                var trainisFound = Regex.Match(input, pattern).Success;

                if (trainisFound)
                {
                    bag.AppendLine(input);
                }
                input =Console.ReadLine();
            }

            var trains = bag.ToString().TrimEnd();
            Console.WriteLine(trains);
        }
    }
}
