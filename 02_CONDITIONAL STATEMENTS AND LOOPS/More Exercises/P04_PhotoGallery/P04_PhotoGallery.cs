using System;
namespace P04_PhotoGallery
{
    class P04_PhotoGallery
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string orientation = "square";
            string sizeIndex = "B";


            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }

            if (size < 1000000 && size > 1000)
            {
                sizeIndex = "KB";
                size /= 1000;
            }
            else if (size > 1000000)
            {
                sizeIndex = "MB";
                size /= 1000000;
            }
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {size}{sizeIndex}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}