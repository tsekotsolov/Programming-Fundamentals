using System;


namespace _03.EmploeeData
{
    class EmploeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:d8}");
            Console.WriteLine($"Salary: {wage:f2}");
        }
    }
}
