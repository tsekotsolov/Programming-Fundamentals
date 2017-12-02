using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_Files
{
    class P04_Files
    {

        class File
        {
            public long FileSize { get; set; }
            public List<string> DirList { get; set; }
            public string FileName { get; set; }

        }
        static void Main()
        {
            var numberOfInputs = int.Parse(Console.ReadLine());

            var dictOfFiles = new SortedDictionary<string, List<File>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine();

                var sizePattern = @"(?<=;)[0-9]+$";
                var filePattern = @"(?<=\\)([^\\]+)(?=;)"; // the file with it's extension
                var dirPattern = @"(?<=\\|)([^\\\n]+)(?=\\)";
                var fileNamePattern = @"^(.+)(?=\.)";
                var fileExtensionPattern = @"(?<=\.)[^.]+$";


                var fileSize = long.Parse(Regex.Match(input, sizePattern).ToString());

                var file = Regex.Match(input, filePattern).ToString().Trim();
                var fileName = Regex.Match(file, fileNamePattern).ToString().Trim();
                var fileExtension = Regex.Match(file, fileExtensionPattern).ToString().Trim();


                var directories = Regex.Matches(input, dirPattern);

                var listOfDirs = new List<string>();

                foreach (Match dir in directories)
                {
                    listOfDirs.Add(dir.ToString().Trim());
                }

                File Currentfile = new File
                {

                    FileSize = fileSize,
                    FileName = fileName,
                    DirList = listOfDirs

                };

                var listofFiles = new List<File>();
                listofFiles.Add(Currentfile);

                if (!dictOfFiles.ContainsKey(fileExtension))
                {
                    dictOfFiles.Add(fileExtension, listofFiles);
                }

                else
                {
                    dictOfFiles[fileExtension].AddRange(listofFiles);
                }
            }

            var command = Console.ReadLine();
            var extension = command.Split(new string[] { " in " }, StringSplitOptions.None).First();
            var directory = command.Split(new string[] { " in " }, StringSplitOptions.None).Skip(1).First();

           

            var result = new Dictionary<string, long>();

            foreach (var item in dictOfFiles)
            {

                if (item.Key == extension)
                {
                    foreach (var file in item.Value)
                    {

                        foreach (var list in file.DirList)
                        {
                            if (file.DirList.Contains(directory))
                            {
                               
                                if (!result.ContainsKey(file.FileName))
                                {
                                    result.Add(file.FileName, file.FileSize);
                                }

                            }
                        }
                    }
                }
               
            }

            if (result.Count!=0)
            {
                foreach (var item in result.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{item.Key}.{extension} - {item.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
