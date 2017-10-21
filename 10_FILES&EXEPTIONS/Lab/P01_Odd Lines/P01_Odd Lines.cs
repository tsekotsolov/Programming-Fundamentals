using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P01_Odd_Lines
{
    class Program
    {
        static void Main()
        {
            string contents = File.ReadAllText("input.txt");

            string[] lines = contents.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            List<string> output = new List<string>();



            for (int i = 1; i < lines.Length; i += 2)
            {
                output.Add(lines[i]);
            }
            File.WriteAllLines("output.txt", output);


        }
    }
}
