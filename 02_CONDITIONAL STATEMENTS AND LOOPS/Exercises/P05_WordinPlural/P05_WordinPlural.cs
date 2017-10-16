using System;
namespace P05_WordinPlural
{
    class P05_WordinPlural
    {
        static void Main()
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                Console.WriteLine(noun + "ies");
            }
            else if(noun.EndsWith("o") || noun.EndsWith("s")|| noun.EndsWith("x")|| noun.EndsWith("z") || noun.EndsWith("sh") || noun.EndsWith("ch"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun+"s");
            }
        }
    }
}
