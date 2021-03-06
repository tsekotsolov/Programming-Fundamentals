﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace P06_ReplaceATag
{
    class P06_ReplaceATag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
