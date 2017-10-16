using System;

namespace P10_Cube_Properties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double faceDiagonal = FindFaceDiagonal(side);
                Console.WriteLine($"{faceDiagonal:f2}");
            }
            else if (parameter =="space")
            {
                double spaceDiagonal = FindSpaceDiagonal(side);
                Console.WriteLine($"{spaceDiagonal:f2}");
            }
            else if (parameter=="volume")
            {
                double volumeOfACube = FindCubevolume(side);
                Console.WriteLine($"{volumeOfACube:f2}");
            }
            else if (parameter=="area")
            {
                double surfaceOfACube = FindSurfaceOfACube(side);
                Console.WriteLine($"{surfaceOfACube:f2}");
            }
            
        }

        private static double FindSurfaceOfACube(double side)
        {
            double cubeSurface = 6*side*side;
            return cubeSurface;
        }

        private static double FindCubevolume(double side)
        {
            double cubeVolume = Math.Pow(side,3);
            return cubeVolume;
        }

        private static double FindSpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * side * side);
            return spaceDiagonal;
        }

        private static double FindFaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * side * side);
            return faceDiagonal;
        }
    }
}
