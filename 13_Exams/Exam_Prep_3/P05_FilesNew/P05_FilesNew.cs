using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_FilesNew
{
    class P05_FilesNew
    {
        class File
        {
            public long Size { get; set; }
            public string Name { get; set; }
            public string Root { get; set; }
        }
        static void Main(string[] args)
        {
            var rootPattern = @"^.+?(?=\\)";
            var sizePattern = @"(?<=;)[0-9]+$";
            var filePattern = @"(?<=\\)([^\\]+)(?=;)"; //extracts the file with it's extension

            int numberofInputs = int.Parse(Console.ReadLine());
            

            var listOfFiles = new List<File>();

            for (int i = 0; i < numberofInputs; i++)
            {
                var input = Console.ReadLine();

                var fileName = Regex.Match(input, filePattern).ToString();
                var fileRoot = Regex.Match(input, rootPattern).ToString();
                var fileSize = long.Parse(Regex.Match(input, sizePattern).ToString());

                File currentFile = new File();
                currentFile.Name = fileName;
                currentFile.Size = fileSize;
                currentFile.Root = fileRoot;

                listOfFiles.Add(currentFile);

            }

            var command = Console.ReadLine();

            var extension = command.Split().First();
            var root = command.Split().Last();

            var result = new Dictionary<string,long>();

            foreach (var file in listOfFiles)
            {
                if (file.Root==root&&file.Name.EndsWith(extension))
                {
                    result[file.Name] = file.Size;
                }
            }

            if (result.Count!=0)
            {
                foreach (var file in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }

            else
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
